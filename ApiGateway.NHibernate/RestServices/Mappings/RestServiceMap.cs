using ApiGateway.Core.RestServices.Model;
using FluentNHibernate.Mapping;

namespace ApiGateway.NHibernate.RestServices.Mappings
{
    public class RestServiceMap : ClassMap<RestService>
    {
        public RestServiceMap()
        {
            Table("TBL_REST_SERVICES");
            Id(x => x.Id, "ID");
            Map(x => x.RequestUrl, "REQUEST_URL");
            Map(x => x.HttpMethod, "HTTP_METHOD");
            Map(x => x.BodyFormat, "BODY_FORMAT");
        }
    }
}