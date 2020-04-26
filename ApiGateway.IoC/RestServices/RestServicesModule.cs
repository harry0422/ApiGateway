using ApiGateway.Core.Contracts.RestServices;
using ApiGateway.Core.RestServices.Managers;
using ApiGateway.Core.RestServices.Repositories;
using ApiGateway.CrossCutting.Transactions;
using ApiGateway.NHibernate.RestServices.Repositories;
using Autofac;
using Autofac.Extras.DynamicProxy;

namespace ApiGateway.IoC.RestServices
{
    public class RestServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<RestServiceRepository>()
                .As<IRestServiceRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));
            
            builder.RegisterType<RestServiceManager>().As<IRestServiceManager>();
        }
    }
}