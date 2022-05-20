using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace APIWeb
{
    public class CustomOAuthProvider: OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            string clientId = string.Empty;
            string clientSecret = string.Empty;
            string symmetricKeyAsBase64 = string.Empty;

            if (!context.TryGetBasicCredentials(out clientId, out clientSecret))
            {
                context.TryGetFormCredentials(out clientId, out clientSecret);
            }

            //if (context.ClientId == null)
            //{
            //    context.SetError("invalid_clientId", "client_Id is not set");
            //    return Task.FromResult<object>(null);
            //}

            //var audience = AudiencesStore.FindAudience(context.ClientId);

            //if (audience == null)
            //{
            //    context.SetError("invalid_clientId", string.Format("Invalid client_id '{0}'", context.ClientId));
            //    return Task.FromResult<object>(null);
            //}
            context.OwinContext.Set<string>("Secret", string.IsNullOrEmpty(clientSecret) ? string.Empty:clientSecret);
            context.Validated(clientId);
            //return Task.FromResult<object>(null);
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.SetError("invalid_grant", "");
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            //check username + password
            if (string.IsNullOrEmpty(context.UserName) || string.IsNullOrEmpty(context.Password))
            {
                context.SetError("invalid_grant", "invalid user");
                return;
                //return Task.FromResult<object>(context);
            }

            ////login here
            //using (AshtelDBContext wmsContext = new AshtelDBContext())
            //using (IUnitOfWorkAsync unitOfWork = new UnitOfWork(wmsContext))
            //{
            //    var administration = new Service.AdministrationService(unitOfWork);
            //    var grant_access = administration.Login(context.UserName, context.Password);
            //    if (grant_access == null)
            //    {
            //        context.SetError("invalid_grant", ErrorResource.IncorrectUserAndPassword);
            //        return Task.FromResult<object>(context);
            //    }
            //    Utilities.InsertLoginUser(unitOfWork, context.UserName);
            
            var identity = new ClaimsIdentity("JWT");
            //var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            

            identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
                identity.AddClaim(new Claim("UserId", "1"));
            identity.AddClaim(new Claim(ClaimTypes.Role, "OK"));
            identity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));
            identity.AddClaim(new Claim("sub", context.UserName));//very importnt


            //var props = new AuthenticationProperties();
            var props = new AuthenticationProperties(new Dictionary<string, string>
                {
                    {
                         "audience", (context.ClientId == null) ? string.Empty : context.ClientId
                         
                    },
                    {
                       "secret", context.OwinContext.Get<string>("Secret")
                    }
                });
            var ticket = new AuthenticationTicket(identity, props);
            context.Validated(ticket);
            //context.Validated(identity);
            //return Task.FromResult<object>(null);
            //}
        }
    }
}