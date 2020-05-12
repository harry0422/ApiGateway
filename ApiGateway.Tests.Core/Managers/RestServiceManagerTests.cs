using ApiGateway.Core.Contracts.RestServices;
using ApiGateway.Core.RestServices.Managers;
using ApiGateway.Core.RestServices.Model;
using ApiGateway.Core.Serializers;
using ApiGateway.Core.Services.Model;
using ApiGateway.Core.Services.Repositories;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace ApiGateway.Tests.Core.Managers
{
    [TestFixture]
    public class RestServiceManagerTests
    {
        Mock<IServiceRepository> mockServiceRepository;
        Mock<IJsonSerializer> mockJsonSerializer;

        [SetUp]
        public void SetUp()
        {
            mockServiceRepository = new Mock<IServiceRepository>();
            mockServiceRepository.Setup(p => p.GetAll()).Returns(It.IsAny<IList<Service>>());
            mockServiceRepository.Setup(p => p.Get(It.IsAny<string>())).Returns(It.IsAny<Service>());
            mockServiceRepository.Setup(p => p.GetByServiceType(ServiceType.REST)).Returns(It.IsAny<IList<Service>>());
            mockServiceRepository.Setup(p => p.Insert(It.IsAny<Service>()));
            mockServiceRepository.Setup(p => p.Update(It.IsAny<Service>()));
            mockServiceRepository.Setup(p => p.Delete(It.IsAny<string>()));

            mockJsonSerializer = new Mock<IJsonSerializer>();
            mockJsonSerializer.Setup(p => p.Serialize(It.IsAny<object>())).Returns(It.IsAny<string>());
            mockJsonSerializer.Setup(p => p.Deserialize<RestService>(It.IsAny<string>())).Returns(It.IsAny<RestService>());
        }

        [Test]
        public void GetAll_ReturnsListOfDto()
        {
            //Arrange
            IRestServiceManager restServiceManager = new RestServiceManager(mockServiceRepository.Object, mockJsonSerializer.Object);

            //Act
            IList<RestServiceDto> restServices = restServiceManager.GetAll();

            //Assert
            Assert.IsNotNull(restServices);
        }
    }
}