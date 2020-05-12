using System.Collections.Generic;

namespace ApiGateway.Core.Contracts.Exposers
{
    public class ExecuteExposerDto
    {
        public ExecuteExposerDto()
        {
            Headers = new List<HeaderDto>();
        }
        public string Path { get; set; }
        public string HttpMethod { get; set; }
        public IList<HeaderDto> Headers { get; set; }
        public string RequestBody { get; set; }
    }
}