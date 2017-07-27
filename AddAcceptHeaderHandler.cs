using System;
using Microsoft.Rest;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DigiCertSharp
{
    public class AddAcceptHeaderHandler : DelegatingHandler
    {
        private const string DIGICERT_REST_JSON = "application/vnd.digicert.rest-v1+json";

        private string _accept;
        public AddAcceptHeaderHandler() : this(DIGICERT_REST_JSON) { }
        public AddAcceptHeaderHandler(string accept) : this(accept, new HttpClientHandler()) { }
        public AddAcceptHeaderHandler(HttpMessageHandler innerHandler) : this(DIGICERT_REST_JSON, innerHandler) { }
        public AddAcceptHeaderHandler(string accept, HttpMessageHandler innerHandler) : base(innerHandler) 
        { 
            _accept = accept;
        }
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Accept", _accept);
            return await base.SendAsync(request, cancellationToken);
        }
    }
}