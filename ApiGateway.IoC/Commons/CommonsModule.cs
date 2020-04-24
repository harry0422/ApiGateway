using ApiGateway.NHibernate.Common;
using Autofac;
using NHibernate;

namespace ApiGateway.IoC.Commons
{
    public class CommonsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            string host = "192.168.99.100";
            int port = 5432;
            string database = "postgres";
            string userName = "postgres";
            string password = "Rodolfo1990";

            builder.RegisterInstance(NhSessionFactory.Create(host, port, database, userName, password))
                .As<ISession>()
                .SingleInstance();
        }
    }
}
