using System.Collections.Generic;

namespace ApiGateway.Core.Contracts.RestServices
{
    public interface IRestServiceManager
    {
        IList<RestServiceDto> GetAllRestServices();
        RestServiceDto GetRestServiceById(RestServiceIdDto dto);
        void AddRestServie(RestServiceRequestDto dto);
        void UpdateRestService(RestServiceDto dto);
        void DeleteRestService(RestServiceIdDto dto);
    }
}