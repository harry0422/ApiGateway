using ApiGateway.Core.Exposers.Model;
using ApiGateway.Core.Exposers.Repositories;
using ApiGateway.NHibernate.Common;
using System.Linq;

namespace ApiGateway.Adapters.Repositories.NHibernate.Exposers
{
    public class ExposerRepository : NhRepositoryBase<Exposer, string>, IExposerRepository
    {
        public Exposer GetByPath(string path)
        {
            return Session.Query<Exposer>()
                .Where(x => x.Path == path)
                .FirstOrDefault();
        }
    }
}