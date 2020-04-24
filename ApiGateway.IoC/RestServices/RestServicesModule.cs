using ApiGateway.Core.Contracts.Managers.RestServices;
using ApiGateway.Core.RestServices.Managers;
using ApiGateway.Core.RestServices.Repositories;
using ApiGateway.NHibernate.RestServices.Repositories;
using Autofac;

namespace ApiGateway.IoC.RestServices
{
    public class RestServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RestServiceRepository>().As<IRestServiceRepository>();
            builder.RegisterType<RestServiceManager>().As<IRestServiceManager>();
        }
    }
}