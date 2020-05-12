using ApiGateway.Core.Contracts.Services;
using ApiGateway.Core.Services.Repositories;
using System.Collections.Generic;

namespace ApiGateway.Core.Services.Managers
{
    public class ServiceManager : IServiceManager
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceManager(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public IList<ServiceDto> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ServiceDto GetById(ServiceIdDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(ServiceRequestDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void Update(ServiceDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(ServiceIdDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}