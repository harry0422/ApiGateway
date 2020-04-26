using ApiGateway.Commons;
using ApiGateway.Core.Exposers.Model;
using System.Collections.Generic;

namespace ApiGateway.Core.Consumers.Model
{
    public class Consumer : EntityBase<string>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public IList<Exposer> Exposers { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}