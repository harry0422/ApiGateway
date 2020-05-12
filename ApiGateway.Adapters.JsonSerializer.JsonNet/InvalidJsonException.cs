using System;
using System.Runtime.Serialization;

namespace ApiGateway.Adapters.JsonSerializer.JsonNet
{
    public class InvalidJsonException : Exception
    {
        public InvalidJsonException(Exception innerException) 
            : base("Invalid json or json not deserializable for the requested type.", innerException)
        {

        }
    }
}