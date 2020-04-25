namespace ApiGateway.Core.Contracts.Managers.RestServices
{
    public class RestServiceIdDto
    {
        public RestServiceIdDto(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
    }
}