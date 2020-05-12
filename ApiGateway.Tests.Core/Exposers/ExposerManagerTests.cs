using ApiGateway.Core.Contracts.Exposers;
using ApiGateway.Core.Exposers.Managers;
using ApiGateway.Core.Exposers.Repositories;
using Moq;
using NUnit.Framework;

namespace ApiGateway.Tests.Core.Exposers
{
    [TestFixture]
    public class ExposerManagerTests
    {
        [SetUp]
        void SetUp()
        {

        }

        [Test]
        public void ExposerManager_ExecuteService()
        {
            //Arrange
            ExecuteExposerDto dto = new ExecuteExposerDto();
            dto.HttpMethod = "GET";
            dto.Path = "";
            dto.RequestBody = "";
            dto.Headers.Add(new HeaderDto() { Name = "Authorization", Value = "Basic 90eruqr98uqr89jfodi" });

            //Act


            //Assert

        }
    }
}