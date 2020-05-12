namespace ApiGateway.Core.Serializers
{
    public interface IJsonSerializer
    {
        string Serialize<TObject>(TObject @object);
        TObject Deserialize<TObject>(string json);
    }
}