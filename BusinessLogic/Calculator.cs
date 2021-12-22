using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   
        // Business Logic
        public class Calculator
        {
            // Business Logic
            public int FindSum(int fno, int sno)
            {
                return fno + sno;
            }

        public int FindDifference(int fno, int sno)
        {
            return fno - sno;
        }

        public int FindProduct(int fno, int sno)
        {
            return fno * sno;
        }

        public double Divide(int fno, int sno)
        {
            return fno / sno;
        }

        }
    }


