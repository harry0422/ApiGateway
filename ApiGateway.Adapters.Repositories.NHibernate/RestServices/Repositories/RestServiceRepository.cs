using ApiGateway.Core.RestServices.Model;
using ApiGateway.Core.RestServices.Repositories;
using ApiGateway.NHibernate.Common;

namespace ApiGateway.NHibernate.RestServices.Repositories
{
    public class RestServiceRepository : NhRepositoryBase<RestService, string>, IRestServiceRepository
    {

    }
}