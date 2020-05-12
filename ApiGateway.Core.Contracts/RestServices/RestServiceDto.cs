namespace ApiGateway.Core.Contracts.RestServices
{
    public class RestServiceDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string RequestUrl { get; set; }
        public string HttpMethod { get; set; }
        public string BodyFormat { get; set; }
    }
}