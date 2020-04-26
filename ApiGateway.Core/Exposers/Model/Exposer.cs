using ApiGateway.Commons;
using ApiGateway.Core.RestServices.Model;

namespace ApiGateway.Core.Exposers.Model
{
    public class Exposer : EntityBase<string>, IAggregateRoot
    {
        public Exposer() { }

        public Exposer(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public RestService RestService { get; set; }

        public void AddRestServie(RestService restService)
        {
            RestService = restService;
        }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}