using System;
using System.Runtime.Serialization;

namespace Smart_Trucks_Kft.Modell
{
    [Serializable]
    internal class ModelKamionNotValidUzemanyagExeption : Exception
    {
        public ModelKamionNotValidUzemanyagExeption()
        {
        }

        public ModelKamionNotValidUzemanyagExeption(string message) : base(message)
        {
        }

        public ModelKamionNotValidUzemanyagExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelKamionNotValidUzemanyagExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}