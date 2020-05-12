using ApiGateway.Core.Exposers.Model;
using FluentNHibernate.Mapping;

namespace ApiGateway.Adapters.Repositories.NHibernate.Exposers
{
    public class ExposerMap : ClassMap<Exposer>
    {
        public ExposerMap()
        {
            Table("tbl_exposers");
            Id(x => x.Id, "id");
            Map(x => x.Name, "name");
            Map(x => x.Path, "path");
            References(x => x.Service, "service_id")
                .Not.LazyLoad();
        }
    }
}