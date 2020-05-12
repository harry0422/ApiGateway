using ApiGateway.Commons;
using System;

namespace ApiGateway.Core.DummyServices.Model
{
    public class DummyService : ValueObjectBase
    {
        public DummyService(string request, string response)
        {
            Request = request;
            Response = response;
        }

        public string Request { get; set; }
        public string Response { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}