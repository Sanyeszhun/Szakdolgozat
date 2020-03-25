using System;
using System.Runtime.Serialization;

namespace Smart_Trucks_Kft.myExeception
{
    [Serializable]
    internal class ModelDolgozoNotValidEmailExeption : Exception
    {
        public ModelDolgozoNotValidEmailExeption()
        {
        }

        public ModelDolgozoNotValidEmailExeption(string message) : base(message)
        {
        }

        public ModelDolgozoNotValidEmailExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelDolgozoNotValidEmailExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}