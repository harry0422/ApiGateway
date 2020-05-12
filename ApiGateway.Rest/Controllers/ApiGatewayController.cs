using ApiGateway.Core.Contracts.Exposers;
using ApiGateway.Core.Exposers.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ApiGateway.Rest.Controllers
{
    [ApiController]
    public class ApiGatewayController : ControllerBase
    {
        private readonly IExposerManager _exposerManager;

        public ApiGatewayController(IExposerManager exposerManager)
        {
            _exposerManager = exposerManager;
        }

        [Route("{*url}")]
        public void ProcessRequest()
        {
            try
            {
                ExecuteExposerDto dto = new ExecuteExposerDto();
                dto.Path = Request.Path;
                dto.HttpMethod = Request.Method;
                dto.RequestBody = BodyToString(Request.Body);
                ExposerResultDto resultDto = _exposerManager.ExecuteExposer(dto);

                Response.StatusCode = resultDto.StatusCode;
                Response.ContentType = "application/json";

                Response.Body.WriteAsync(Encoding.UTF8.GetBytes(resultDto.Body), 0, resultDto.Body.Length);
            }
            catch (ExposerDoesNotExistException e)
            {
                Response.StatusCode = 404;
            }
            catch (Exception e)
            {
                Response.StatusCode = 500;
            }
        }

        private string BodyToString(Stream body)
        {
            using (var reader = new StreamReader(body, Encoding.UTF8))
            {
                Task<string> task = reader.ReadToEndAsync();
                return task.Result;
            }
        }

        private Stream StringToBody(string str)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(str);
            return new MemoryStream(byteArray);
        }
    }
}