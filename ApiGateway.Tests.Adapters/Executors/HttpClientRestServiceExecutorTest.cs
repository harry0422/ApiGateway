using ApiGateway.Adapters.RestServiceExecutor.HttpClient;
using ApiGateway.Core.RestServices.Executors;
using ApiGateway.Core.RestServices.Model;
using NUnit.Framework;

namespace ApiGateway.Tests.Adapters.Executors
{
    [TestFixture]
    public class HttpClientRestServiceExecutorTest
    {
        [Test]
        public void HttpClientRestServiceExecutor_ReturnOKResult()
        {
            //Arrange
            IRestServiceExecutor executor = new HttpClientRestServiceExecutor();
            
            RestService restService = new RestService("https://reqres.in/api/users/", "GET", "");

            RestServiceRequest request = new RestServiceRequest(restService, "GET", null, "");
            
            //Act
            RestServiceResponse response = executor.Execute(request);

            //Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(response.StatusCode, 200);
            Assert.IsTrue(!string.IsNullOrEmpty(response.Body));
        }
    }
}