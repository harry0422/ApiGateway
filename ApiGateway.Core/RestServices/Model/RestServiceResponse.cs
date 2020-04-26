using ApiGateway.Commons;
using System.Collections.Generic;

namespace ApiGateway.Core.RestServices.Model
{
    public class RestServiceResponse : ValueObjectBase
    {
        public int StatusCode { get; set; }
        public IList<Header> Headers { get; set; }
        public string Body { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}