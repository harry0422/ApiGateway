using ApiGateway.Commons;
using ApiGateway.Core.Exposers.Model;

namespace ApiGateway.Core.Exposers.Repositories
{
    public interface IExposerRepository : IRepository<Exposer, string>
    {
        Exposer GetByPath(string path);
    }
}