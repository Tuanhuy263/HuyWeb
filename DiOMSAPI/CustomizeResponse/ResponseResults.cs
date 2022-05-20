using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using DiOMSAPI.ResponseModels;

namespace DiOMSAPI.CustomizeResponse
{
    public class CustomOKResultResponse : IHttpActionResult
    {
        private readonly HttpRequestMessage _request;
        private readonly string _message;
        private readonly object _data;
        public CustomOKResultResponse(HttpRequestMessage request, string message, dynamic data = null)
        {
            _request = request;
            _message = message;
            _data = data;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            JsonResponseModel jsonResponseModel = new JsonResponseModel()
            {
                Data = _data,
                Message = _message,
                StatusCode = HttpStatusCode.OK,
            };

            var response = _request.CreateResponse(HttpStatusCode.OK, jsonResponseModel);
            return Task.FromResult(response);
        }
    }

    public class CustomNotFoundResultResponse : IHttpActionResult
    {
        private readonly HttpRequestMessage _request;
        private readonly string _message;
        private readonly dynamic _data;
        public CustomNotFoundResultResponse(HttpRequestMessage request, string message, dynamic data = null)
        {
            _request = request;
            _message = message;
            _data = data;

        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            JsonResponseModel jsonResponseModel = new JsonResponseModel()
            {
                Data = _data,
                Message = _message,
                StatusCode = HttpStatusCode.NotFound,
            };

            var response = _request.CreateResponse(HttpStatusCode.OK, jsonResponseModel);
            return Task.FromResult(response);
        }
    }

    public class CustomBadRequestResultResponse : IHttpActionResult
    {
        private readonly HttpRequestMessage _request;
        private readonly string _message;
        private readonly dynamic _data;
        public CustomBadRequestResultResponse(HttpRequestMessage request, string message, dynamic data = null)
        {
            _request = request;
            _message = message;
            _data = data;

        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            JsonResponseModel jsonResponseModel = new JsonResponseModel()
            {
                Data = _data,
                Message = _message,
                StatusCode = HttpStatusCode.BadRequest,
            };

            var response = _request.CreateResponse(HttpStatusCode.OK, jsonResponseModel);
            return Task.FromResult(response);
        }
    }

    public class CustomExpectationFailedResultResponse : IHttpActionResult
    {
        private readonly HttpRequestMessage _request;
        private readonly string _message;
        private readonly dynamic _data;
        public CustomExpectationFailedResultResponse(HttpRequestMessage request, string message, dynamic data = null)
        {
            _request = request;
            _message = message;
            _data = data;

        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            JsonResponseModel jsonResponseModel = new JsonResponseModel()
            {
                Data = _data,
                Message = _message,
                StatusCode = HttpStatusCode.ExpectationFailed,
            };

            var response = _request.CreateResponse(HttpStatusCode.OK, jsonResponseModel);
            return Task.FromResult(response);
        }
    }

    public class CustomFileActionResult : IHttpActionResult
    {
        private readonly HttpRequestMessage _request;
        public CustomFileActionResult(HttpRequestMessage request, string fileName, System.IO.MemoryStream streamContent)
        {
            this._request = request;
            this.FileName = fileName;
            this.StreamContent = streamContent;
        }

        public string FileName { get; private set; }
        public System.IO.MemoryStream StreamContent { get; private set; }
        public Task<HttpResponseMessage> ExecuteAsync(System.Threading.CancellationToken cancellationToken)
        {
            var response = _request.CreateResponse(HttpStatusCode.OK);
            //HttpResponseMessage response = new HttpResponseMessage();
            response.Headers.Clear();

            response.Content = new StreamContent(this.StreamContent);
            response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
            response.Content.Headers.ContentDisposition.FileName = this.FileName;
            System.Net.Http.Headers.MediaTypeHeaderValue mediaType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            response.Content.Headers.ContentType = mediaType;

            return Task.FromResult(response);
        }
    }
}