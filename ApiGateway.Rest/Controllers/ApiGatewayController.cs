using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Rest.Controllers
{

    public class ApiGatewayController : ControllerBase
    {
        [Route("{*url}")]
        public string ProcessRequest()
        {
            string path = Request.Path;
            string method = Request.Method;
            string body = Request.Body.ToString();


            return path;
        }
    }
}