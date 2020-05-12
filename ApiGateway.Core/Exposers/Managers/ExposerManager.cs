using ApiGateway.Core.Contracts.Exposers;
using ApiGateway.Core.Exposers.Exceptions;
using ApiGateway.Core.Exposers.Mappers;
using ApiGateway.Core.Exposers.Model;
using ApiGateway.Core.Exposers.Repositories;
using ApiGateway.Core.RestServices.Executors;
using ApiGateway.Core.RestServices.Mappers;
using ApiGateway.Core.RestServices.Model;
using ApiGateway.Core.Serializers;
using ApiGateway.Core.Services.Model;
using ApiGateway.Core.Services.Repositories;
using System.Collections.Generic;

namespace ApiGateway.Core.Exposers.Managers
{
    public class ExposerManager : IExposerManager
    {
        private readonly IExposerRepository _exposerRepository;
        private readonly IServiceRepository _serviceRepository;
        private readonly IJsonSerializer _jsonSerializer;
        private readonly IRestServiceExecutor _restServiceExecutor;

        public ExposerManager(IExposerRepository exposerRepository, IServiceRepository serviceRepository, IJsonSerializer jsonSerializer, IRestServiceExecutor restServiceExecutor)
        {
            _exposerRepository = exposerRepository;
            _serviceRepository = serviceRepository;
            _jsonSerializer = jsonSerializer;
            _restServiceExecutor = restServiceExecutor;
        }

        public IList<ExposerDto> GetAll()
        {
            IList<Exposer> exposers = _exposerRepository.GetAll();
            return exposers.ToDto();
        }

        public ExposerDto GetExposerById(ExposerIdDto dto)
        {
            Exposer exposer = _exposerRepository.Get(dto.Id);
            return exposer.ToDto();
        }

        public void Insert(InsertExposerDto dto)
        {
            Service servie = _serviceRepository.Get(dto.ServiceId);
            Exposer exposer = new Exposer(dto.Name, dto.Path, servie);

            _exposerRepository.Insert(exposer);
        }

        public void UpdateExposer(ExposerDto dto)
        {
            Exposer exposer = _exposerRepository.Get(dto.Id);
            exposer.Name = dto.Name;
            exposer.Path = dto.Path;

            _exposerRepository.Update(exposer);
        }

        public void DeleteExposer(ExposerIdDto dto)
        {
            _exposerRepository.Delete(dto.Id);
        }

        public ExposerResultDto ExecuteExposer(ExecuteExposerDto dto)
        {
            Exposer exposer = _exposerRepository.GetByPath(dto.Path);
            if (exposer == null) throw new ExposerDoesNotExistException();

            IList<Header> headers = new List<Header>();

            foreach (var h in dto.Headers)
            {
                headers.Add(new Header(h.Name, h.Value));
            }

            switch (exposer.Service.ServiceType)
            {
                case ServiceType.DUMMY:
                    return null;
                case ServiceType.REST:
                    RestService restService = _jsonSerializer.Deserialize<RestService>(exposer.Service.JsonDetails);
                    RestServiceRequest request = new RestServiceRequest(restService, dto.HttpMethod, headers, dto.RequestBody);
                    RestServiceResponse response = _restServiceExecutor.Execute(request);

                    return response.ToDto();
                case ServiceType.SOAP:
                    return null;
                case ServiceType.DATABASE:
                    return null;
                default:
                    return null;
            }

        }
    }
}