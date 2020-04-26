using ApiGateway.Commons;
using System;

namespace ApiGateway.Core.RestServices.Model
{
    public class RestService : EntityBase<string>, IAggregateRoot
    {
        public RestService() { }
        public RestService(string requestUrl, string httpMethod, string bodyFormat)
        {
            Id = Guid.NewGuid().ToString().Replace("-", "");
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