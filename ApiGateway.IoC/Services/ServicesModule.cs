using ApiGateway.Adapters.Repositories.NHibernate.Services;
using ApiGateway.Core.Services.Repositories;
using ApiGateway.CrossCutting.Transactions;
using Autofac;
using Autofac.Extras.DynamicProxy;

namespace ApiGateway.IoC.Services
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<ServiceRepository>()
                .As<IServiceRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));
        }
    }
}