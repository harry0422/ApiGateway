using System;

namespace ApiGateway.Core.Exposers.Exceptions
{
    public class ExposerDoesNotExistException : Exception
    {
        public ExposerDoesNotExistException() : base("Exposer does not exist.")
        {

        }
    }
}