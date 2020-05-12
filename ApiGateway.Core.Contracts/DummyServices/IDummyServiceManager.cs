using System.Collections.Generic;

namespace ApiGateway.Core.Contracts.DummyServices
{
    public interface IDummyServiceManager
    {
        IList<DummyServiceDto> GetAll();
        DummyServiceDto GetById(DummyServiceIdDto dto);
        void Insert(InsertDummyServiceDto dto);
        void Update(DummyServiceDto dto);
        void Delete(DummyServiceIdDto dto);
    }
}