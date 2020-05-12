using ApiGateway.Core.Services.Model;
using FluentNHibernate.Mapping;

namespace ApiGateway.Adapters.Repositories.NHibernate.Services
{
    public class ServiceMap : ClassMap<Service>
    {
        public ServiceMap()
        {
            Table("tbl_services");
            Id(x => x.Id, "id");
            Map(x => x.Name, "name");
            Map(x => x.ServiceType, "service_type");
            Map(x => x.JsonDetails, "service_details");
        }
    }
}