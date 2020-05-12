using ApiGateway.Commons;
using System;

namespace ApiGateway.Core.RestServices.Model
{
    public class RestService : ValueObjectBase
    {
        public RestService(string requestUrl, string httpMethod, string bodyFormat)
        {
            RequestUrl = requestUrl;
            HttpMethod = httpMethod;
            BodyFormat = bodyFormat;
        }

        public virtual string RequestUrl { get; set; }
        public virtual string HttpMethod { get; set; }
        public virtual string BodyFormat { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}