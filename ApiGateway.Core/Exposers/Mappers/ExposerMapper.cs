using ApiGateway.Core.Contracts.Exposers;
using ApiGateway.Core.Exposers.Model;
using System.Collections.Generic;

namespace ApiGateway.Core.Exposers.Mappers
{
    public static class ExposerMapper
    {
        public static ExposerDto ToDto(this Exposer entity)
        {
            if (entity == null) return null;

            ExposerDto dto = new ExposerDto();
            dto.Id = entity.Id;
            dto.Name = entity.Name;
            dto.Path = entity.Path;

            return dto;
        }

        public static IList<ExposerDto> ToDto(this IList<Exposer> entity)
        {
            if (entity == null) return null;

            IList<ExposerDto> dto = new List<ExposerDto>();

            foreach (var e in entity)
            {
                dto.Add(e.ToDto());
            }

            return dto;
        }
    }
}