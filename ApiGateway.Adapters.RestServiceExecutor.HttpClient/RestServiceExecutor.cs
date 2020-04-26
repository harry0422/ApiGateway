﻿using ApiGateway.Core.RestServices.Executors;
using ApiGateway.Core.RestServices.Model;
using System;
using System.Net.Http;
using System.Threading.Tasks;

using NetCoreHttpClient = System.Net.Http.HttpClient;

namespace ApiGateway.Adapters.RestServiceExecutor.HttpClient
{
    public class RestServiceExecutor : IRestServiceExecutor
    {
        //TODO: Improve code
        public RestServiceResponse Execute(RestServiceRequest restServiceRequest)
        {
            using (NetCoreHttpClient client = new NetCoreHttpClient()) 
            {
                //Create request
                HttpRequestMessage request = new HttpRequestMessage();
                request.RequestUri = new Uri(restServiceRequest.RequestUrl);
                request.Method = new HttpMethod(restServiceRequest.HttpMethod);

                foreach (var h in restServiceRequest.Headers)
                {
                    request.Headers.Add(h.Name, h.Value);
                }

                request.Content = new StringContent(restServiceRequest.Body);

                //Call Service
                Task<HttpResponseMessage> responseTask = client.SendAsync(request);
                HttpResponseMessage response = responseTask.Result;

                //Create response
                RestServiceResponse restServiceResponse = new RestServiceResponse();

                foreach (var h in response.Headers)
                {
                    restServiceResponse.Headers.Add(new Header(h.Key, h.Value.ToString()));
                }

                restServiceResponse.StatusCode = Convert.ToInt32(response.StatusCode.ToString());
                restServiceResponse.Body = response.Content.ToString();

                return restServiceResponse;
            }
        }
    }
}