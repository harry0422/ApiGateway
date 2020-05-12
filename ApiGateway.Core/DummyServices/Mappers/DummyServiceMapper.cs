using ApiGateway.Core.Contracts.DummyServices;
using ApiGateway.Core.DummyServices.Model;

namespace ApiGateway.Core.DummyServices.Mappers
{
    public static class DummyServiceMapper
    {
        public static DummyServiceDto ToDto(this DummyService entity)
        {
            if (entity == null) return null;

            DummyServiceDto dto = new DummyServiceDto();
            dto.Request = entity.Request;
            dto.Response = entity.Response;

            return dto;
        }
    }
}