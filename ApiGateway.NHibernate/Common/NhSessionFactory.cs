using ApiGateway.NHibernate.RestServices.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;

namespace ApiGateway.NHibernate.Common
{
    public static class NhSessionFactory
    {
        public static ISessionFactory Create(string host, int port, string database, string userName, string password)
        {
            try
            {
                return Fluently.Configure()
                    .Database(PostgreSQLConfiguration.PostgreSQL82
                    .ConnectionString(c => c
                    .Host(host)
                    .Port(port)
                    .Database(database)
                    .Username(userName)
                    .Password(password)))
                    .Mappings(c => c.FluentMappings.AddFromAssemblyOf<RestServiceMap>())
                    .BuildSessionFactory();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}