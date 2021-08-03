using System;
using System.Runtime.Serialization;

namespace HW_Lesson_14
{
    [Serializable]
    internal class WeDoNotFixTotalLostException : ApplicationException
    {
        public WeDoNotFixTotalLostException()
        {
        }

        public WeDoNotFixTotalLostException(string message) : base(message)
        {
        }

        public WeDoNotFixTotalLostException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeDoNotFixTotalLostException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}