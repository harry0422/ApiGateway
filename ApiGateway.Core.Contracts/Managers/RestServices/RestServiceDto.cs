namespace ApiGateway.Core.Contracts.Managers.RestServices
{
    public class RestServiceDto
    {
        public RestServiceDto(string id, string requestUrl, string httpMethod, string bodyFormat)
        {
            Id = id;
            RequestUrl = requestUrl;
            HttpMethod = httpMethod;
            BodyFormat = bodyFormat;
        }

        public string Id { get; set; }
        public string RequestUrl { get; set; }
        public string HttpMethod { get; set; }
        public string BodyFormat { get; set; }
    }
}