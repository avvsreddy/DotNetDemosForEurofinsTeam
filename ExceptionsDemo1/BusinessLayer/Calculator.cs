using ExceptionsDemo1.CustomExceptions;
using ExceptionsDemo1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo1.BusinessLayer
{
    /// <summary>
    /// 
    /// </summary>
    public class Calculator
    {

        /// <summary>
        /// Finds the sum of two positive int numbers
        /// </summary>
        /// <param name="a">Positive int</param>
        /// <param name="b">Positive int</param>
        /// <returns>Returns the sum of two positive ints</returns>
        /// <exception cref="InvalidInputException"></exception>
        public int Sum(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new InvalidInputException("Input values cannot be negetive");
            }
            int result = a + b;
            PersistData repo = new PersistData();
            try
            {
                repo.SaveInput(a, b, result);
            }
            catch (AppDomainUnloadedException ex)
            {
                // convert
                UnableToSaveInputException exp = new UnableToSaveInputException("Unable to save the input into the database",ex);

                // log

                // Log4net
                // serilog
                //Nlog
                // ELMAH
                //log.Log(ex);

                //throw exp;
            }
            return result;
        }
    }
}
