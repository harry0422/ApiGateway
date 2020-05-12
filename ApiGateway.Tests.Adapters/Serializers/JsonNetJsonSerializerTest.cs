using ApiGateway.Adapters.JsonSerializer.JsonNet;
using ApiGateway.Core.RestServices.Model;
using ApiGateway.Core.Serializers;
using NUnit.Framework;

namespace ApiGateway.Tests.Adapters.Serializers
{
    [TestFixture]
    public class JsonNetJsonSerializerTest
    {
        private IJsonSerializer jsonSerializer;
        private string testJson;
        private string invalidJson;
        private string wrongStructureJson;

        [SetUp]
        public void Setup()
        {
            jsonSerializer = new JsonNetJsonSerializer();
            testJson = "{\"RequestUrl\":\"https://reqres.in/api/users/\",\"HttpMethod\":\"GET\",\"BodyFormat\":\"{ \\\"Nombre\\\" : \\\"Carlos\\\" }\"}";
            invalidJson = "\"RequestUrl\":\"https://reqres.in/api/users/\",\"HttpMethod\":\"GET\",\"BodyFormat\":\"{ \\\"Nombre\\\" : \\\"Carlos\\\" }\"}";
            wrongStructureJson = "{ \"Name\" ; \"Carlos\" }";
        }

        [Test]
        public void JsonNetJsonSerializer_SerializeObject()
        {
            //Arrange
            RestService restService = new RestService("https://reqres.in/api/users/", "GET", "{ \"Nombre\" : \"Carlos\" }");

            //Act
            string testJson = jsonSerializer.Serialize(restService);

            //Assert
            Assert.AreEqual(this.testJson, testJson);
        }

        [Test]
        public void JsonNetJsonSerializer_DeserializeObject()
        {
            //Arrange

            //Act
            RestService restService = jsonSerializer.Deserialize<RestService>(testJson);

            //Assert
            Assert.AreEqual("https://reqres.in/api/users/", restService.RequestUrl);
            Assert.AreEqual("GET", restService.HttpMethod);
            Assert.AreEqual("{ \"Nombre\" : \"Carlos\" }", restService.BodyFormat);
        }

        [Test]
        public void JsonNetJsonSerializer_DeserializeInvalidJsonThrowsException()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<InvalidJsonException>(() => jsonSerializer.Deserialize<RestService>(invalidJson));
        }

        [Test]
        public void JsonNetJsonSerializer_DeserializeWrongStructureJsonThrowsException()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<InvalidJsonException>(() => jsonSerializer.Deserialize<RestService>(wrongStructureJson));
        }


    }
}