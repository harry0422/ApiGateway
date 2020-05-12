using ApiGateway.Commons;
using System.Collections.Generic;

namespace ApiGateway.Core.RestServices.Model
{
    public class RestServiceRequest : ValueObjectBase
    {
        public RestServiceRequest(RestService restService, string httpMethod, IList<Header> headers, string body)
        {
            RequestUrl = restService.RequestUrl;
            HttpMethod = httpMethod;
            Headers = headers;
            Body = body;
        }

        public string RequestUrl { get; set; }
        public string HttpMethod { get; set; }
        public IList<Header> Headers { get; set; }
        public string Body { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}