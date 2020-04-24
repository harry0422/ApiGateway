using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Rest.Controllers
{

    public class ApiGatewayController : ControllerBase
    {
        [Route("{*url}")]
        public string ProcessRequest()
        {
            string path = Request.Path;
            return path;
        }
    }
}