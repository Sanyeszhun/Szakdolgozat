using System;
using System.Runtime.Serialization;

namespace Smart_Trucks_Kft.myExeception
{
    [Serializable]
    internal class ModelDolgozoNotValidNevExeption : Exception
    {
        public ModelDolgozoNotValidNevExeption()
        {
        }

        public ModelDolgozoNotValidNevExeption(string message) : base(message)
        {
        }

        public ModelDolgozoNotValidNevExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelDolgozoNotValidNevExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}