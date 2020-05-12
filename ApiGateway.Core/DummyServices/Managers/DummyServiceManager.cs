using ApiGateway.Core.Contracts.DummyServices;
using ApiGateway.Core.DummyServices.Mappers;
using ApiGateway.Core.DummyServices.Model;
using ApiGateway.Core.Serializers;
using ApiGateway.Core.Services.Model;
using ApiGateway.Core.Services.Repositories;
using System.Collections.Generic;

namespace ApiGateway.Core.DummyServices.Managers
{
    public class DummyServiceManager : IDummyServiceManager
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IJsonSerializer _jsonSerializer;

        public DummyServiceManager(IServiceRepository serviceRepository, IJsonSerializer jsonSerializer)
        {
            _serviceRepository = serviceRepository;
            _jsonSerializer = jsonSerializer;
        }

        public IList<DummyServiceDto> GetAll()
        {
            IList<DummyServiceDto> dto = new List<DummyServiceDto>();
            IList<Service> services = _serviceRepository.GetByServiceType(ServiceType.DUMMY);

            foreach (var s in services)
            {
                DummyService dummyService = _jsonSerializer.Deserialize<DummyService>(s.JsonDetails);
                dto.Add(dummyService.ToDto());
            }

            return dto;
        }

        public DummyServiceDto GetById(DummyServiceIdDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(InsertDummyServiceDto dto)
        {
            DummyService dummyService = new DummyService(dto.Request, dto.Response);
            string jsonDetails = _jsonSerializer.Serialize(dummyService);
            Service service = new Service(dto.Name, ServiceType.DUMMY, jsonDetails);
            _serviceRepository.Insert(service);
        }

        public void Update(DummyServiceDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(DummyServiceIdDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}
