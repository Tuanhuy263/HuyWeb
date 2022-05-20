using DiOMSCloud.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DiOMSCloud.ResponseModels;
using System.Configuration;
using Microsoft.AspNet.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Principal;

namespace DiOMSCloud.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        public ActionResult Index()
        {
            //FormsAuthentication.Authenticate()

            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login(string returnUrl,string lang)
        {
            ViewBag.ReturnUrl = returnUrl;
            ViewData["Language"] = string.IsNullOrEmpty(lang) ? "English" : lang;
            ViewData["Dictionary"] = HttpContext.Application["Dictionary"];
            SecurityModel obj = new SecurityModel();
            return View(obj);
            
        }

        //[NonAction]
        //private TokenResponseModel GetTokenFromAPI(string username, string password)
        //{
        //    var getTokenUrl = ConfigurationManager.AppSettings["APIToken"];

        //    //"http://localhost:51254/huy/token";

        //    using (HttpClient httpClient = new HttpClient())
        //    {
        //        HttpContent content = new FormUrlEncodedContent(new[]
        //        {
        //            new KeyValuePair<string, string>("grant_type", "password"),
        //            new KeyValuePair<string, string>("username", username),
        //            new KeyValuePair<string, string>("password", password)
        //        });

        //        HttpResponseMessage result = httpClient.PostAsync(getTokenUrl, content).Result;

        //        string resultContent = result.Content.ReadAsStringAsync().Result;

        //        var token = JsonConvert.DeserializeObject<TokenResponseModel>(resultContent);

        //        return token;
        //    }
        //}

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(string returnUrl, SecurityModel obj)
        //FormCollection frm)
        {
            if (ModelState.IsValid)
            {
                string username = obj.UserName;
                string passwd = obj.Password;
                string capcha = obj.CapchaLetters;
                
                if (!username.Equals("huy") || !passwd.Equals("huy")||!capcha.Equals(TempData["CapchaLetters"].ToString()))
                {
                    ViewData["Language"] = Request["Language"] != null ? Request["Language"].ToString() : "English";
                    ViewData["Dictionary"] = HttpContext.Application["Dictionary"];
                    return View();
                }
                var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, obj.UserName), }, DefaultAuthenticationTypes.ApplicationCookie);
                TokenResponseModel res = ExtraProcess.GetTokenFromAPI(obj.UserName, obj.Password);
                Session["Access_Token"] = res.Access_token;
                Session["password"] = obj.Password;
                JwtSecurityToken token = ExtraProcess.DeEncodeJWT(res.Access_token);
                List<Claim> cls = token.Claims.Where(claim => claim.Type == ClaimTypes.Role).ToList();
                foreach (Claim cl in cls)
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, cl.Value));
                }
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()));
                HttpContext.GetOwinContext().Authentication.SignIn(identity);
                if(Request["Language"] != null)
                {
                    Session["Language"] = Request["Language"];
                    Session["Dictionary"] = HttpContext.Application["Dictionary"];
                }
                
                #region ASP.Net Authentication
                //FormsAuthentication.SetAuthCookie(username, false);
                //var authTicket = new FormsAuthenticationTicket(1, username, DateTime.Now, DateTime.Now.AddMinutes(5), false, "admin");
                //string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                //var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                //HttpContext.Response.Cookies.Add(authCookie);
                #endregion

                if (string.IsNullOrEmpty(returnUrl))
                {
                    return RedirectToAction("Index", "SO", new { area = "Demand" });
                }

                return Redirect(returnUrl);
            }
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                //FormsAuthentication.SignOut();
                HttpContext.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                HttpContext.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);
                Session["Language"] = null;
            }
            return RedirectToAction("Login", "Security");

        }

        
        [AllowAnonymous]
        [HttpGet]
        public ActionResult GenerateCapchaImage()
        {
            MemoryStream stream = new MemoryStream();
            string captcha = string.Empty;
            stream = ExtraProcess.GetCaptchaImage(out captcha);
            TempData["CapchaLetters"] = captcha;
            if (Session != null)
            {
                //if (login)
                //{
                    Session["CaptchaLogin"] = captcha;
                //}
                //else
                //{
                //    Session["CaptchaRegister"] = captcha;
                //}
            }
            return new FileStreamResult(stream, "image/png");
        }
    }
}