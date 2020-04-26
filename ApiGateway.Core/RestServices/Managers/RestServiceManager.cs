using ApiGateway.Core.Contracts.RestServices;
using ApiGateway.Core.RestServices.Mappers;
using ApiGateway.Core.RestServices.Model;
using ApiGateway.Core.RestServices.Repositories;
using System.Collections.Generic;

namespace ApiGateway.Core.RestServices.Managers
{
    public class RestServiceManager : IRestServiceManager
    {
        private readonly IRestServiceRepository _restServiceRepository;

        public RestServiceManager(IRestServiceRepository restServiceRepository)
        {
            _restServiceRepository = restServiceRepository;
        }

        public IList<RestServiceDto> GetAllRestServices()
        {
            IList<RestService> restServices =  _restServiceRepository.GetAll();
            return restServices.ToDto();
        }

        public RestServiceDto GetRestServiceById(RestServiceIdDto dto)
        {
            RestService restService = _restServiceRepository.Get(dto.Id);
            return restService.ToDto();
        }

        public void AddRestServie(RestServiceRequestDto dto)
        {
            RestService restService = new RestService(dto.RequestUrl, dto.HttpMethod, dto.BodyFormat);
            _restServiceRepository.Insert(restService);
        }

        public void UpdateRestService(RestServiceDto dto)
        {
            RestService restService = _restServiceRepository.Get(dto.Id);
            restService.RequestUrl = dto.RequestUrl;
            restService.HttpMethod = dto.HttpMethod;
            restService.BodyFormat = dto.BodyFormat;

            _restServiceRepository.Update(restService);
        }

        public void DeleteRestService(RestServiceIdDto dto)
        {
            _restServiceRepository.Delete(dto.Id);
        }
    }
}