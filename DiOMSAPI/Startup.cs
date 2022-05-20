using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using APIWeb;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler.Encoder;
using Microsoft.Owin.Security.Jwt;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System.Linq;

[assembly: OwinStartup(typeof(APIWeb.Startup))]

namespace APIWeb
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            // Web API routes
            config.MapHttpAttributeRoutes();

            ConfigureOAuth(app);

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

        }

        public void ConfigureOAuth(IAppBuilder app)
        {

            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                //For Dev enviroment only (on production should be AllowInsecureHttp = false)
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/huy/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
                Provider = new CustomOAuthProvider(),
                AccessTokenFormat = new CustomJwtFormat("http://jwtauthzsrv.azurewebsites.net")
            };

            // OAuth 2.0 Bearer Access Token Generation
            //UseJwtBearerAuthentication
            app.UseOAuthAuthorizationServer(OAuthServerOptions);

            //app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());//only use bear authentication
            //var hh = new OAuthBearerAuthenticationOptions();hh.AccessTokenFormat.

            List<string> secrets = new List<string>() { "IxrAjDoa2FqElO7IhrSrUJELhUckePEPVpaePlS_Xaw", "u-HhHSi0BZeDrBkfqHU_BgdaB_qo_EdKCV86wT13ggGzm_Hb7i_dZ8ekZrkldYY66_66TpbnrzmK0hf4fUHzkQ" };
            app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions()
            {
                AuthenticationMode = AuthenticationMode.Active,
                AllowedAudiences = new[] { "AnnaKen","Any" },
                IssuerSecurityKeyProviders = new IIssuerSecurityKeyProvider[]
                {
                     new SymmetricKeyIssuerSecurityKeyProvider("http://jwtauthzsrv.azurewebsites.net",secrets.Select(x=>{
                        return TextEncodings.Base64Url.Decode(x);
                     }))
                     //TextEncodings.Base64Url.Decode(""))
                }
            });

        }
    }
}
