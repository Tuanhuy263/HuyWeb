using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiOMSCloud.ResponseModels
{
    public class OAuthErrorMsg
    {
        public string Error { get; set; }
        public string Error_description { get; set; }

    }
    public class TokenResponseModel
    {

        public string Access_token { get; set; }
        public string Token_type { get; set; }
        public long Expires_in { get; set; }

        public string Invalid_grant { get; set; }

        public string Refresh_token { get; set; }

        public string Error { get; set; }
    }
    public class JsonResponseModel
    {
        public JsonResponseModel()
        {
            this.StatusCode = System.Net.HttpStatusCode.OK;
        }
        public System.Net.HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }

        public object Data { get; set; }

    }
}