using ApiGateway.Commons;
using ApiGateway.Core.Services.Model;
using System.Collections.Generic;

namespace ApiGateway.Core.Services.Repositories
{
    public interface IServiceRepository : IRepository<Service, string>
    {
        IList<Service> GetByServiceType(ServiceType serviceType);
    }
}