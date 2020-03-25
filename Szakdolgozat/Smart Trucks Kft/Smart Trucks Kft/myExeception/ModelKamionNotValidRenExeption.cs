using System;
using System.Runtime.Serialization;

namespace Smart_Trucks_Kft.myExeception
{
    [Serializable]
    internal class ModelKamionNotValidRenExeption : Exception
    {
        public ModelKamionNotValidRenExeption()
        {
        }

        public ModelKamionNotValidRenExeption(string message) : base(message)
        {
        }

        public ModelKamionNotValidRenExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelKamionNotValidRenExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}