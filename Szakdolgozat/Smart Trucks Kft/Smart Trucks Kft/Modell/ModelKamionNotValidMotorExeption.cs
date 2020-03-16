using System;
using System.Runtime.Serialization;

namespace Smart_Trucks_Kft.Modell
{
    [Serializable]
    internal class ModelKamionNotValidMotorExeption : Exception
    {
        public ModelKamionNotValidMotorExeption()
        {
        }

        public ModelKamionNotValidMotorExeption(string message) : base(message)
        {
        }

        public ModelKamionNotValidMotorExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelKamionNotValidMotorExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}