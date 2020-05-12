using System.Collections.Generic;

namespace ApiGateway.Core.Contracts.Exposers
{
    public class ExposerResultDto
    {
        public int StatusCode { get; set; }
        public IList<HeaderDto> Headers { get; set; }
        public string Body { get; set; }
    }
}