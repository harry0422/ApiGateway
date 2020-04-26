using ApiGateway.Commons;

namespace ApiGateway.Core.Credentials.Model
{
    public class Credential : EntityBase<string>
    {
        public CredentialType CredentialType { get; set; }
        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
