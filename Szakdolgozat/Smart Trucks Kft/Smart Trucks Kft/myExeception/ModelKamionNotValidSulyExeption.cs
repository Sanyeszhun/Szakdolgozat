using System;
using System.Runtime.Serialization;

namespace Smart_Trucks_Kft.Modell
{
    [Serializable]
    internal class ModelKamionNotValidSulyExeption : Exception
    {
        public ModelKamionNotValidSulyExeption()
        {
        }

        public ModelKamionNotValidSulyExeption(string message) : base(message)
        {
        }

        public ModelKamionNotValidSulyExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelKamionNotValidSulyExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}