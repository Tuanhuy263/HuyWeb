using AutoMapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace DiOMSCloud
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            UnityConfig.RegisterComponents();
            log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/Web.config")));
            AutoMapperConfig.RegisterMapping();
            Application["Dictionary"] = ExtraProcess.LoadMultiLanguagesResource();
        }

        protected void Session_End(Object sender, EventArgs e)
        {
            Session.Clear();
        }
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
                //for ASP.Net MVC Authentication
               
                //var authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];

                //if (authCookie != null)
                //{
                //    var ticket = FormsAuthentication.Decrypt(authCookie.Value);
                //    FormsIdentity formsIdentity = new FormsIdentity(ticket);
                //    ClaimsIdentity claimsIdentity = new ClaimsIdentity(formsIdentity);
                //    claimsIdentity.AddClaim(
                //            new Claim(ClaimTypes.Role, "OK"));
                //    claimsIdentity.AddClaim(
                //            new Claim(ClaimTypes.Role, "Admin"));
                //    //var user = this.UserService.GetUserByEmail(ticket.Name);

                //    //foreach (var role in user.Roles)
                //    //{
                //    //    claimsIdentity.AddClaim(
                //    //        new Claim(ClaimTypes.Role, role));
                //    //}

                //    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                //    HttpContext.Current.User = claimsPrincipal;
                //}
        }
    }
}
