using System;
using System.Runtime.Serialization;

namespace StudentResult.CalculatorLibrary
{
    [Serializable]
    public class InvalidMarksException : ApplicationException
    {
        public InvalidMarksException()
        {
        }

        public InvalidMarksException(string message) : base(message)
        {
        }

        public InvalidMarksException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidMarksException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}