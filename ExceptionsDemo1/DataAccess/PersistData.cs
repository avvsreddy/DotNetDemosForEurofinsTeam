using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo1.DataAccess
{
    public class PersistData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        /// <exception cref="AppDomainUnloadedException"></exception>
        public bool SaveInput(int a, int b, int result)
        {
            // connect to db
            // send data 
            // close db
            // return true
            throw new AppDomainUnloadedException();


            return true;
        }
    }
}
