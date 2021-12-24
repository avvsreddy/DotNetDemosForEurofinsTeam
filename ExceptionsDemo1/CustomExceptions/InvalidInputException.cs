using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo1.CustomExceptions
{
    /// <summary>
    /// Throws when input is negative
    /// </summary>
    public class InvalidInputException : ApplicationException
    {
        public InvalidInputException(string message) : base(message)
        {
            //Message = message;
        }
    }
}
