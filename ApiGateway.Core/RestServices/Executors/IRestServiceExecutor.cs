using ApiGateway.Core.RestServices.Model;

namespace ApiGateway.Core.RestServices.Executors
{
    public interface IRestServiceExecutor
    {
        RestServiceResponse Execute(RestServiceRequest restServiceRequest);
    }
}