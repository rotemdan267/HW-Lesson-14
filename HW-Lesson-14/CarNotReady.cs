using System;
using System.Runtime.Serialization;

namespace HW_Lesson_14
{
    [Serializable]
    internal class CarNotReady : ApplicationException
    {
        public CarNotReady()
        {
        }

        public CarNotReady(string message) : base(message)
        {
        }

        public CarNotReady(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarNotReady(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}