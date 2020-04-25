using ApiGateway.CrossCutting.Transactions;
using ApiGateway.CrossCutting.Transactions.NHibernate;
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
            string password = "Honduras2020";

            builder.RegisterType<TransactionInterceptor>().SingleInstance();

            builder.RegisterInstance(NhSessionFactory.Create(host, port, database, userName, password))
                .As<ISessionFactory>()
                .SingleInstance();

            builder.RegisterType<NhUnitOfWork>().As<IUnitOfWork>();

        }
    }
}
