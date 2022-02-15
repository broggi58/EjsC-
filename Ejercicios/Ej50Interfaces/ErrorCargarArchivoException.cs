using System;
using System.Runtime.Serialization;

namespace Ej50Interfaces
{
    [Serializable]
    internal class ErrorCargarArchivoException : Exception
    {
        public ErrorCargarArchivoException()
        {
        }

        public ErrorCargarArchivoException(string message) : base(message)
        {
        }

        public ErrorCargarArchivoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ErrorCargarArchivoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}