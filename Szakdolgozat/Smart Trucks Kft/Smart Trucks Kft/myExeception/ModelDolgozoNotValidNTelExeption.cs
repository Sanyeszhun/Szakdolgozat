using System;
using System.Runtime.Serialization;

namespace Smart_Trucks_Kft.myExeception
{
    [Serializable]
    internal class ModelDolgozoNotValidNTelExeption : Exception
    {
        public ModelDolgozoNotValidNTelExeption()
        {
        }

        public ModelDolgozoNotValidNTelExeption(string message) : base(message)
        {
        }

        public ModelDolgozoNotValidNTelExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelDolgozoNotValidNTelExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}