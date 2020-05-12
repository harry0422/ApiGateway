using ApiGateway.Core.Contracts.Exposers;
using ApiGateway.Core.RestServices.Model;
using System.Collections.Generic;

namespace ApiGateway.Core.RestServices.Mappers
{
    public static class HeaderMap
    {
        public static HeaderDto ToDto(this Header header)
        {
            if (header == null) return null;

            HeaderDto dto = new HeaderDto();
            dto.Name = header.Name;
            dto.Value = header.Value;

            return dto;
        }

        public static IList<HeaderDto> ToDto(this IList<Header> headers)
        {
            if (headers == null) return null;

            IList<HeaderDto> dto = new List<HeaderDto>();

            foreach (var h in headers)
            {
                dto.Add(h.ToDto());
            }

            return dto;
        }
    }
}