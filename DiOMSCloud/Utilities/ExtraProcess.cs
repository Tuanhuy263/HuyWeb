using SRVTextToImage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.IdentityModel.Tokens.Jwt;
using DiOMSCloud.ResponseModels;
using System.Configuration;
using System.Net.Http;
using Newtonsoft.Json;
using DiOMSCloud.Utilities;
using System.Xml.Linq;
using System.Web.Hosting;

namespace DiOMSCloud
{
    public class ExtraProcess
    {
        public static MemoryStream GetCaptchaImage(out string captcha)
        {
            CaptchaRandomImage CI = new CaptchaRandomImage();
            captcha = CI.GetRandomString(5); // here 5 means I want to get 5 char long captcha
            //CI.GenerateImage(this.Session["CaptchaImageText"].ToString(), 300, 75);
            // Or We can use another one for get custom color Captcha Image 
            CI.GenerateImage(captcha, 300, 75, Color.DarkGray, Color.White);
            MemoryStream stream = new MemoryStream();
            CI.Image.Save(stream, ImageFormat.Png);
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        public static JwtSecurityToken DeEncodeJWT(string val)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(val);
            var tokenS = handler.ReadToken(val) as JwtSecurityToken;
            //var id = tokenS.Claims.First(claim => claim.Type == "UserId").Value;
            return tokenS;
        }

        public static TokenResponseModel GetTokenFromAPI(string username, string password)
        {
            ServiceFactory sv = new ServiceFactory();
            return sv.PostForToken("huy/token", username, password);

            #region old
            //var getTokenUrl = ConfigurationManager.AppSettings["APIToken"];
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    HttpContent content = new FormUrlEncodedContent(new[]
            //    {
            //        new KeyValuePair<string, string>("grant_type", "password"),
            //        new KeyValuePair<string, string>("username", username),
            //        new KeyValuePair<string, string>("password", password)
            //    });

            //    HttpResponseMessage result = httpClient.PostAsync(getTokenUrl, content).Result;

            //    string resultContent = result.Content.ReadAsStringAsync().Result;

            //    var token = JsonConvert.DeserializeObject<TokenResponseModel>(resultContent);

            //    return token;
            //}
            #endregion
        }

        public static bool JWTExpired(string jwt)
        {
            bool result = false;
            var jwthandler = new JwtSecurityTokenHandler();
            var jwttoken = jwthandler.ReadToken(jwt);
            var expDate = jwttoken.ValidTo;
            if (expDate < DateTime.UtcNow.AddMinutes(1))
                result = true;
            return result;
        }

        public static Dictionary<string,string> LoadMultiLanguagesResource()
        {
            XDocument xmlDoc =  XDocument.Load(HostingEnvironment.MapPath("~/Languages/ForeignLanguage.xml"));
            List<XElement> lst = xmlDoc.Descendants("View").ToList();
            if(lst != null)
            {
                Dictionary<string, string> dics = new Dictionary<string, string>();
                lst.ForEach(element =>
                {
                    string key = element.Attribute("Name").Value;
                    foreach(XElement childElement in element.Descendants())
                    {
                        foreach (XElement bottomElement in childElement.Descendants())
                        {
                            dics.Add(key + childElement.Attribute("Name").Value + bottomElement.Name, bottomElement.Value);
                        }
                    }
                });
                return dics; 
            }
            return null;
        }

        public static string SelectedLanguage
        {
            get
            {
                return HttpContext.Current.Session["Language"].ToString();
            }
        }

    }
}