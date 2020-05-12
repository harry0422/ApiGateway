using System.Collections.Generic;

namespace ApiGateway.Core.Contracts.RestServices
{
    public interface IRestServiceManager
    {
        IList<RestServiceDto> GetAll();
        RestServiceDto GetById(RestServiceIdDto dto);
        void Insert(InsertRestServiceDto dto);
        void Update(RestServiceDto dto);
        void Delete(RestServiceIdDto dto);
    }
}