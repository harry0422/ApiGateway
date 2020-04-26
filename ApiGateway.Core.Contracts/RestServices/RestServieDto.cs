using System.Collections.Generic;

namespace ApiGateway.Core.Contracts.RestServices
{
    public class RestServieDto
    {
        public string RequestUrl { get; set; }
        public string HttpMethod { get; set; }
        public string BodyFormat { get; set; }

    }
}