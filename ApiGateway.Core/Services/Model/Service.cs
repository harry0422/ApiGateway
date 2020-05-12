using ApiGateway.Commons;
using System;

namespace ApiGateway.Core.Services.Model
{
    public class Service : EntityBase<string>, IAggregateRoot
    {
        public Service() { }
        public Service(string name, ServiceType serviceType, string jsonDetails)
        {
            Id = Guid.NewGuid().ToString().Replace("-", "");
            Name = name;
            ServiceType = serviceType;
            JsonDetails = jsonDetails;
        }

        public virtual string Name { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual string JsonDetails { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}