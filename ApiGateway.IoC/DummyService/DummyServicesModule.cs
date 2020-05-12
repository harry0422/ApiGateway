using ApiGateway.Core.Contracts.DummyServices;
using ApiGateway.Core.DummyServices.Managers;
using Autofac;

namespace ApiGateway.IoC.DummyService
{
    public class DummyServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DummyServiceManager>().As<IDummyServiceManager>();
        }
    }
}