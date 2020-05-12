using ApiGateway.Adapters.Repositories.NHibernate.Exposers;
using ApiGateway.Core.Contracts.Exposers;
using ApiGateway.Core.Exposers.Managers;
using ApiGateway.Core.Exposers.Repositories;
using ApiGateway.CrossCutting.Transactions;
using Autofac;
using Autofac.Extras.DynamicProxy;

namespace ApiGateway.IoC.Exposers
{
    public class ExposersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<ExposerRepository>()
                .As<IExposerRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionInterceptor));

            builder.RegisterType<ExposerManager>().As<IExposerManager>();
        }
    }
}