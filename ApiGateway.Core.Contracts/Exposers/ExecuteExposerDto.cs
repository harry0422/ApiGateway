using System.Collections.Generic;

namespace ApiGateway.Core.Contracts.Exposers
{
    public class ExecuteExposerDto
    {
        public string Path { get; set; }
        public IList<HeaderDto> Headers { get; set; }
        public string RequestBody { get; set; }
    }
}