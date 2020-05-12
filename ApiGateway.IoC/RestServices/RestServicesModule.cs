using ApiGateway.Adapters.RestServiceExecutor.HttpClient;
using ApiGateway.Core.Contracts.RestServices;
using ApiGateway.Core.RestServices.Executors;
using ApiGateway.Core.RestServices.Managers;
using Autofac;

namespace ApiGateway.IoC.RestServices
{
    public class RestServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RestServiceManager>().As<IRestServiceManager>();
            builder.RegisterType<HttpClientRestServiceExecutor>().As<IRestServiceExecutor>();
        }
    }
}