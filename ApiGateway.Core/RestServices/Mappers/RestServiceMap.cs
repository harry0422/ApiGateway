using ApiGateway.Core.Contracts.Managers.RestServices;
using ApiGateway.Core.RestServices.Model;
using System.Collections.Generic;

namespace ApiGateway.Core.RestServices.Mappers
{
    public static class RestServiceMap
    {
        public static RestServiceDto ToDto(this RestService entity)
        {
            if (entity == null) return null;

            RestServiceDto dto = new RestServiceDto();
            dto.Id = entity.Id;
            dto.RequestUrl = entity.RequestUrl;
            dto.HttpMethod = entity.HttpMethod;
            dto.BodyFormat = entity.BodyFormat;

            return dto;
        }

        public static IList<RestServiceDto> ToDto(this IList<RestService> entity)
        {
            if (entity == null) return null;

            IList<RestServiceDto> dto = new List<RestServiceDto>();

            foreach (var e in entity)
            {
                dto.Add(e.ToDto());
            }

            return dto;
        }
    }
}