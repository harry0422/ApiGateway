using ApiGateway.Commons;
using ApiGateway.Core.Services.Model;
using System;

namespace ApiGateway.Core.Exposers.Model
{
    public class Exposer : EntityBase<string>, IAggregateRoot
    {
        public Exposer() { }

        public Exposer(string name, string path, Service service)
        {
            Id = Guid.NewGuid().ToString().Replace("-", "");
            Name = name;
            Path = path;
            Service = service;
        }

        public virtual string Name { get; set; }
        public virtual string Path { get; set; }
        public virtual Service Service { get; set; }

        public virtual void AddServie(Service service)
        {
            Service = service;
        }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}