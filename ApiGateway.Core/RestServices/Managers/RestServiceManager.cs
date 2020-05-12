using ApiGateway.Core.Contracts.RestServices;
using ApiGateway.Core.RestServices.Mappers;
using ApiGateway.Core.RestServices.Model;
using ApiGateway.Core.Serializers;
using ApiGateway.Core.Services.Model;
using ApiGateway.Core.Services.Repositories;
using System.Collections.Generic;

namespace ApiGateway.Core.RestServices.Managers
{
    public class RestServiceManager : IRestServiceManager
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IJsonSerializer _jsonSerializer;

        public RestServiceManager(IServiceRepository serviceRepository, IJsonSerializer jsonSerializer)
        {
            _serviceRepository = serviceRepository;
            _jsonSerializer = jsonSerializer;
        }

        public IList<RestServiceDto> GetAll()
        {
            IList<RestServiceDto> dto = new List<RestServiceDto>();

            IList<Service> restServices = _serviceRepository.GetByServiceType(ServiceType.REST);

            foreach (var s in restServices)
            {
                RestService restService = _jsonSerializer.Deserialize<RestService>(s.JsonDetails);
                dto.Add(restService.ToDto());
            }

            return dto;
        }

        public RestServiceDto GetById(RestServiceIdDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(InsertRestServiceDto dto)
        {
            RestService restService = new RestService(dto.RequestUrl, dto.HttpMethod, dto.BodyFormat);
            string jsonDetails = _jsonSerializer.Serialize(restService);
            Service service = new Service(dto.Name, ServiceType.REST, jsonDetails);

            _serviceRepository.Insert(service);
        }

        public void Update(RestServiceDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(RestServiceIdDto dto)
        {
            _serviceRepository.Delete(dto.Id);
        }
    }
}