using DiOMSAPI.Filter;
using DiOMSRepositoryEntity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DiOMSAPI.CustomizeResponse;
using DiOMSAPI.ResponseModels;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using System.Web;

namespace DiOMSAPI.Controllers
{
    public class TestController : ApiController
    {
        private IUnitOfWork _unit;

        public TestController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [Authorize(Roles = "Admin")]
        //[CustomizedAuthen]
        [HttpGet]
        // GET api/values/5
        public IHttpActionResult ReturnVal()
        {
            #region get claim infromation
            //var handler = new JwtSecurityTokenHandler();
            //var jsonToken = handler.ReadToken("eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoidHVhbmh1eSIsIlVzZXJJZCI6IjEiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJhbG8iLCJzdWIiOiJ0dWFuaHV5IiwibmJmIjoxNjQ3Nzk0OTUxLCJleHAiOjE2NDc3OTY3NTEsImlzcyI6Imh0dHA6Ly9qd3RhdXRoenNydi5henVyZXdlYnNpdGVzLm5ldCIsImF1ZCI6IkFueSJ9.Zq20cm_-sARldp_0emnvsRsG2_ezR4I-5TZQtqV2pXg");
            //var tokenS = handler.ReadToken("eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoidHVhbmh1eSIsIlVzZXJJZCI6IjEiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJhbG8iLCJzdWIiOiJ0dWFuaHV5IiwibmJmIjoxNjQ3Nzk0OTUxLCJleHAiOjE2NDc3OTY3NTEsImlzcyI6Imh0dHA6Ly9qd3RhdXRoenNydi5henVyZXdlYnNpdGVzLm5ldCIsImF1ZCI6IkFueSJ9.Zq20cm_-sARldp_0emnvsRsG2_ezR4I-5TZQtqV2pXg") as JwtSecurityToken;
            //var id = tokenS.Claims.First(claim => claim.Type == "UserId").Value;
            #endregion

            GenericRepository<DiOMSEntity.DIS_SOHeader> ctr = _unit.GeneralRepository<DiOMSEntity.DIS_SOHeader>();
            var lst = ctr.GetQuery.Select(x=>new { SONumber = x.SONumber, Note = x.Note }).First();

            CustomOKResultResponse res = new CustomOKResultResponse(Request, "Get Sales Order", Newtonsoft.Json.JsonConvert.SerializeObject(lst));
            //HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.OK, Newtonsoft.Json.JsonConvert.SerializeObject(lst));
            return res;
            //return "value";
            //return Json(new {sonumber = obj.SONumber, sooriginalnumber = obj.SOOriginalNumber, sodate = obj.SODate, Hub = obj.DIS_Hub.HubCode });
        }

        [Authorize(Roles = "OK")]
        [HttpGet]
        public IHttpActionResult LoadItem(ItemCriteria abc)
        {
            ItemCriteria obj = null;
            if (Request.Content != null)
            {
                string val = Request.Content.ReadAsStringAsync().Result;
                obj = JsonConvert.DeserializeObject<ItemCriteria>(val);
            }
            GenericRepository<DiOMSEntity.DIS_MasterItem> ctr = _unit.GeneralRepository<DiOMSEntity.DIS_MasterItem>();
            var lst = ctr.GetQuery.Where(x => (string.IsNullOrEmpty(obj.ERPItemCode) || obj.ERPItemCode.Equals(x.ERPItemCode)))
                        .Where(x => (string.IsNullOrEmpty(obj.ItemType) || obj.ItemType.Contains(x.ManagementType.ToString()))).Select(x => new {ERPItemCode = x.ERPItemCode, Description = x.Description, Category = x.DIO_GroupItem.GroupItemCode, ItemType = x.ManagementType });
            if (lst != null)
            {
                CustomOKResultResponse res = new CustomOKResultResponse(Request, "Get Item", Newtonsoft.Json.JsonConvert.SerializeObject(lst));
                return res;
            }

            CustomNotFoundResultResponse notFound = new CustomNotFoundResultResponse(Request, "Not found Item", null);
            return notFound;
        }

        

        [HttpGet]
        public async Task<TokenResponseModel> Login(string userName, string password)
        {
            var getTokenUrl = HttpContext.Current.Request.UserHostName + "/huy/token";
                //"http://localhost:51254/huy/token";

            using (HttpClient httpClient = new HttpClient())
            {
                HttpContent content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", userName),
                    new KeyValuePair<string, string>("password", password)
                });

                HttpResponseMessage result = httpClient.PostAsync(getTokenUrl, content).Result;

                string resultContent = result.Content.ReadAsStringAsync().Result;

                var token = JsonConvert.DeserializeObject<TokenResponseModel>(resultContent);

                return token;
                //AuthenticationProperties options = new AuthenticationProperties();

                //options.AllowRefresh = true;
                //options.IsPersistent = true;
                //options.ExpiresUtc = DateTime.UtcNow.AddSeconds(int.Parse(token.expires_in));

                //var claims = new[]
                //{
                //    new Claim(ClaimTypes.Name, model.EmailAddress),
                //    new Claim("AcessToken", string.Format("Bearer {0}", token.access_token)),
                //};

                //var identity = new ClaimsIdentity(claims, "ApplicationCookie");

                //Request.GetOwinContext().Authentication.SignIn(options, identity);

            }






            //var rootUrl = "http://localhost:51254/huy/token";
            //WebRequest request = WebRequest.Create(rootUrl);
            //request.Method = "Get";
            //request.ContentType = "application/json";
            //string postJson = $"grant_type=password&UserName={userName}&Password={password}";
            //    //$"&Client_id={"099153c2625149bc8ecb3e85e03f0022"}";
            //byte[] bytes = Encoding.UTF8.GetBytes(postJson);
            //try
            //{
            //    using (Stream stream = await request.GetRequestStreamAsync())
            //    {
            //        stream.Write(bytes, 0, bytes.Length);
            //    }

            //    HttpWebResponse httpResponse = (HttpWebResponse)(await request.GetResponseAsync());
            //    string json;
            //    using (Stream responseStream = httpResponse.GetResponseStream())
            //    {
            //        json = new StreamReader(responseStream).ReadToEnd();
            //    }
            //    TokenResponseModel tokenResponse = JsonConvert.DeserializeObject<TokenResponseModel>(json);
            //    return tokenResponse;
            //}
            //catch (WebException ex)
            //{

            //    string jsonResult = string.Empty;
            //    using (var stream = ex.Response.GetResponseStream())
            //    {
            //        using (var reader = new StreamReader(stream))
            //        {
            //            jsonResult = reader.ReadToEnd();

            //        }
            //    }
            //    OAuthErrorMsg tokenResponse = JsonConvert.DeserializeObject<OAuthErrorMsg>(jsonResult);
            //    TokenResponseModel model = new TokenResponseModel()
            //    {
            //        Invalid_grant = tokenResponse.Error_description,
            //    };

            //    return model;
            //}
        }
    }
}