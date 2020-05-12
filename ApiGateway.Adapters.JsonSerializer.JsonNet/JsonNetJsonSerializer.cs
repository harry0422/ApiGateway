using ApiGateway.Core.Serializers;
using Newtonsoft.Json;
using System;

namespace ApiGateway.Adapters.JsonSerializer.JsonNet
{
    public class JsonNetJsonSerializer : IJsonSerializer
    {

        public TObject Deserialize<TObject>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<TObject>(json);
            }
            catch (Exception e)
            {
                throw new InvalidJsonException(e);
            }
        }

        public string Serialize<TObject>(TObject @object)
        {
            return JsonConvert.SerializeObject(@object);
        }
    }
}