using System.Collections.Generic;

namespace ApiGateway.Core.Contracts.Managers.RestServices
{
    public class RestServiceRequestDto
    {
        public RestServiceRequestDto(string requestUrl, string httpMethod, string bodyFormat)
        {
            RequestUrl = requestUrl;
            HttpMethod = httpMethod;
            BodyFormat = bodyFormat;
        }

        public string RequestUrl { get; set; }
        public string HttpMethod { get; set; }
        public string BodyFormat { get; set; }

    }
}