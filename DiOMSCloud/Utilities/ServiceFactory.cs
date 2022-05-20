using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using System.Web;
using Newtonsoft.Json;
using System.Text;
using DiOMSCloud.Areas.Demand.Models;
using DiOMSCloud.ResponseModels;

namespace DiOMSCloud.Utilities
{
    public class ServiceFactory
    {
        public JsonResponseModel Get(string route,params string[] pars)
        {
            var uri = ConfigurationManager.AppSettings["APIUrl"];
            var authentication = new AuthenticationHeaderValue("Bearer", HttpContext.Current.Session["Access_Token"].ToString());
            if(pars != null && pars.Length > 0)
            {
                route = route + "?";
                string queryString = string.Join("&", pars);
                route = route + queryString;
            }
            HttpResponseMessage response = RequestData(uri, route, authentication);
            if (response.IsSuccessStatusCode)
            {
                JsonResponseModel result = response.Content.ReadAsAsync<JsonResponseModel>().Result;//System.Net.Formatting
                return result;
            }
            return null;
        }

        public JsonResponseModel Post(string route, string json, params string[] pars)
        {
            var uri = ConfigurationManager.AppSettings["APIUrl"];
            var authentication = new AuthenticationHeaderValue("Bearer", HttpContext.Current.Session["Access_Token"].ToString());
            if (pars != null && pars.Length > 0)
            {
                route = route + "?";
                string queryString = string.Join("&", pars);
                route = route + queryString;
            }
            HttpResponseMessage response = PostData(uri, route, json,authentication);
            if (response.IsSuccessStatusCode)
            {
                JsonResponseModel result = response.Content.ReadAsAsync<JsonResponseModel>().Result;
                return result;
            }
            return null;
        }

        public JsonResponseModel PostWithoutToken(string route, string json, params string[] pars)
        {
            var uri = ConfigurationManager.AppSettings["APIUrl"];
            if (pars != null && pars.Length > 0)
            {
                route = route + "?";
                string queryString = string.Join("&", pars);
                route = route + queryString;
            }
            
            HttpResponseMessage response = PostData(uri, route, json, null);
            if (response.IsSuccessStatusCode)
            {
                JsonResponseModel result = response.Content.ReadAsAsync<JsonResponseModel>().Result;
                return result;
            }
            return null;
        }

        public TokenResponseModel PostForToken(string route,string username, string password)
        {
            var uri = ConfigurationManager.AppSettings["APIUrl"];
            HttpResponseMessage response = PostDataForJWT(uri, route, username, password);
            if (response.IsSuccessStatusCode)
            {
                TokenResponseModel result = response.Content.ReadAsAsync<TokenResponseModel>().Result;
                return result;
            }
            return null;
        }

        private HttpResponseMessage RequestData(string uri, string route, AuthenticationHeaderValue authentication)
        {
            //using (var handler = new HttpClientHandler { CookieContainer = _cookieContainer })
            //{
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                //client.DefaultRequestHeaders.TryAddWithoutValidation("Bearer ", Infrastructure.Security.WMSPrincipal.AccessToken);
                client.DefaultRequestHeaders.Clear();
                //client.DefaultRequestHeaders.Add("Pass", "huy");
                client.DefaultRequestHeaders.Authorization = authentication;
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                return client.GetAsync(route).Result;
            }
            //}
        }

        private HttpResponseMessage PostData(string uri, string route, string json, AuthenticationHeaderValue authentication)
        {
            //using (var handler = new HttpClientHandler { CookieContainer = _cookieContainer })
            //{
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                // client.DefaultRequestHeaders.TryAddWithoutValidation("Bearer ", Infrastructure.Security.WMSPrincipal.AccessToken);
                client.DefaultRequestHeaders.Clear();
                if (authentication != null)
                {
                    client.DefaultRequestHeaders.Authorization = authentication;
                }
                //client.DefaultRequestHeaders.Add("Pass", "huy");
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                return client.PostAsync(route, content).Result;
            }
            //}
        }

        private HttpResponseMessage PostDataForJWT(string uri, string route,string username, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Clear();
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password", password)
                });

                return client.PostAsync(route, content).Result;
            }
        }
    }
}