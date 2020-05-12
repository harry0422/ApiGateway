using System;
using System.Collections.Generic;
using System.Text;

namespace ApiGateway.Core.Contracts.Services
{
    public interface IServiceManager
    {
        IList<ServiceDto> GetAll();
        ServiceDto GetById(ServiceIdDto dto);
        void Insert(ServiceRequestDto dto);
        void Update(ServiceDto dto);
        void Delete(ServiceIdDto dto);
    }
}