using ApiGateway.Core.Contracts.Exposers;
using ApiGateway.Core.RestServices.Model;

namespace ApiGateway.Core.RestServices.Mappers
{
    public static class RestServiceResponseMap
    {
        public static ExposerResultDto ToDto(this RestServiceResponse response)
        {
            ExposerResultDto dto = new ExposerResultDto();
            dto.StatusCode = response.StatusCode;
            dto.Body = response.Body;
            dto.Headers = response.Headers.ToDto();

            return dto;
        }
    }
}
