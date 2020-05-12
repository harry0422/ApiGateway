using ApiGateway.Adapters.JsonSerializer.JsonNet;
using ApiGateway.Core.Serializers;
using Autofac;

namespace ApiGateway.IoC.Serializers
{
    public class SerializersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<JsonNetJsonSerializer>()
                .As<IJsonSerializer>();
        }
    }
}