using ApiGateway.Core.Contracts.Managers.RestServices;
using ApiGateway.Core.RestServices.Model;
using ApiGateway.Core.RestServices.Repositories;

namespace ApiGateway.Core.RestServices.Managers
{
    public class RestServiceManager : IRestServiceManager
    {
        private readonly IRestServiceRepository _restServiceRepository;

        public RestServiceManager(IRestServiceRepository restServiceRepository)
        {
            _restServiceRepository = restServiceRepository;
        }

        public void AddRestServie(RestServieDto dto)
        {
            RestService restService = new RestService(dto.RequestUrl, dto.HttpMethod, dto.BodyFormat);
        }
    }
}