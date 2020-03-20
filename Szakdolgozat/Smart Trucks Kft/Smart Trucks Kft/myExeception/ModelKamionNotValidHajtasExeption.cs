using System;
using System.Runtime.Serialization;

namespace Smart_Trucks_Kft.myExeception
{
    [Serializable]
    internal class ModelKamionNotValidHajtasExeption : Exception
    {
        public ModelKamionNotValidHajtasExeption()
        {
        }

        public ModelKamionNotValidHajtasExeption(string message) : base(message)
        {
        }

        public ModelKamionNotValidHajtasExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelKamionNotValidHajtasExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}