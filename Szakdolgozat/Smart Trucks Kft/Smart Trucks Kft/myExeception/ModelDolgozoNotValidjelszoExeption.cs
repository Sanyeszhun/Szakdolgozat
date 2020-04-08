using System;
using System.Runtime.Serialization;

namespace Smart_Trucks_Kft.Modell
{
    [Serializable]
    internal class ModelDolgozoNotValidjelszoExeption : Exception
    {
        public ModelDolgozoNotValidjelszoExeption()
        {
        }

        public ModelDolgozoNotValidjelszoExeption(string message) : base(message)
        {
        }

        public ModelDolgozoNotValidjelszoExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelDolgozoNotValidjelszoExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}