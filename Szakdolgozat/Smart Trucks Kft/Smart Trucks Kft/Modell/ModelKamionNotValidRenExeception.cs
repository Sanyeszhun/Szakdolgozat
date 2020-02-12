using System;
using System.Runtime.Serialization;

namespace Smart_Trucks_Kft.Modell
{
    [Serializable]
    internal class ModelKamionNotValidRenExeception : Exception
    {
        public ModelKamionNotValidRenExeception()
        {
        }

        public ModelKamionNotValidRenExeception(string message) : base(message)
        {
        }

        public ModelKamionNotValidRenExeception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelKamionNotValidRenExeception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}