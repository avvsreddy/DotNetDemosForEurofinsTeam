using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo1.CustomExceptions
{
    public class UnableToSaveInputException : ApplicationException
    {
        //public UnableToSaveInputException()
        //{

        //}
        //public UnableToSaveInputException(string msg) : base(msg)
        //{

        //}

        public UnableToSaveInputException(string msg=null, Exception innerExp=null):base(msg,innerExp)
        {

        }
    }
}
