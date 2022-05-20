using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler.Encoder;
using System;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
//using System.IdentityModel.Tokens.Jwt;
using Thinktecture.IdentityModel.Tokens;


namespace APIWeb
{
    public class CustomJwtFormat : ISecureDataFormat<AuthenticationTicket>
    {
        private const string AudiencePropertyKey = "audience";

        private readonly string _issuer = string.Empty;

        public CustomJwtFormat(string issuer)
        {
            _issuer = issuer;
        }

        public string Protect(AuthenticationTicket data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            string audienceId =  data.Properties.Dictionary.ContainsKey(AudiencePropertyKey) ? data.Properties.Dictionary[AudiencePropertyKey] : null;
            if(string.IsNullOrEmpty(audienceId))
            {
                audienceId = "Any";
            }
            //if (string.IsNullOrWhiteSpace(audienceId)) throw new InvalidOperationException("AuthenticationTicket.Properties does not include audience");

            //Audience audience = AudiencesStore.FindAudience(audienceId);

            #region experiment of new secret key
            //var key = new byte[64];
            //RNGCryptoServiceProvider.Create().GetBytes(key);
            //var secret = TextEncodings.Base64Url.Encode(key);
            #endregion

            string symmetricKeyAsBase64 = data.Properties.Dictionary.ContainsKey("secret") ? data.Properties.Dictionary["secret"] : null;
            if(string.IsNullOrEmpty(symmetricKeyAsBase64))
            {
                symmetricKeyAsBase64 = "IxrAjDoa2FqElO7IhrSrUJELhUckePEPVpaePlS_Xaw";
            }
            //"u-HhHSi0BZeDrBkfqHU_BgdaB_qo_EdKCV86wT13ggGzm_Hb7i_dZ8ekZrkldYY66_66TpbnrzmK0hf4fUHzkQ";
            //"IxrAjDoa2FqElO7IhrSrUJELhUckePEPVpaePlS_Xaw";
            //"IxrAjDoa2FqElO7IhrSrUJELhUckePEPVpaePlS_Xaw";
            //ConfigurationManager.AppSettings["Secret"];// "IxrAjDoa2FqElO7IhrSrUJELhUckePEPVpaePlS_Xaw";//audience.Base64Secret;

            var keyByteArray = TextEncodings.Base64Url.Decode(symmetricKeyAsBase64);

            //var signingKey = new HmacSigningCredentials(keyByteArray);


            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(keyByteArray);
            var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(
                        securityKey, SecurityAlgorithms.HmacSha256Signature);

            var issued = data.Properties.IssuedUtc;
            var expires = data.Properties.ExpiresUtc;

            var token = new JwtSecurityToken(_issuer, audienceId, data.Identity.Claims, issued.Value.UtcDateTime, expires.Value.UtcDateTime, signingCredentials);

            var handler = new JwtSecurityTokenHandler();

            var jwt = handler.WriteToken(token);
            
            return jwt;
        }

        public AuthenticationTicket Unprotect(string protectedText)
        {
            throw new NotImplementedException();
        }
    }
}