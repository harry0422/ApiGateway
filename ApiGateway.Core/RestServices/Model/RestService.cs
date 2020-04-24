using ApiGateway.Common;

namespace ApiGateway.Core.RestServices.Model
{
    public class RestService : EntityBase<string>, IAggregateRoot
    {
        public RestService(string requestUrl, string httpMethod, string bodyFormat)
        {
            RequestUrl = requestUrl;
            HttpMethod = httpMethod;
            BodyFormat = bodyFormat;
        }

        public string RequestUrl { get; set; }
        public string HttpMethod { get; set; }
        public string BodyFormat { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}