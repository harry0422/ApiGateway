using ApiGateway.Core.Services.Model;
using ApiGateway.Core.Services.Repositories;
using ApiGateway.NHibernate.Common;
using System.Collections.Generic;
using System.Linq;

namespace ApiGateway.Adapters.Repositories.NHibernate.Services
{
    public class ServiceRepository : NhRepositoryBase<Service, string>, IServiceRepository
    {
        public IList<Service> GetByServiceType(ServiceType serviceType)
        {
            return Session.Query<Service>()
                .Where(x => x.ServiceType == serviceType)
                .ToList();
        }
    }
}