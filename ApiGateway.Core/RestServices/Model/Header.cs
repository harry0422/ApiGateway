using ApiGateway.Commons;

namespace ApiGateway.Core.RestServices.Model
{
    public class Header : ValueObjectBase
    {
        public Header(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}