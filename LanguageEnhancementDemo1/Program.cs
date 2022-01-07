using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEnhancementDemo1
{



    class Program
    {
        static void Main(string[] args)
        {
            // var - local variables type inference
            // Object initialization syntax
            // Anonymous Objects
            // Extension Methods

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // sql select
            // select number from numbers where number mod 2 = 0;

            // LINQ Query Expression
            var evens = from n in numbers where n % 2 == 0 select n;

            // Linq Extension Methods

            var otherway = numbers.Where(n => n % 2 == 0).Select(n => n);

            List<int> evenNumbers = new List<int>();
            foreach (var n in numbers)
            {
                if(n % 2 == 0)
                {
                    evenNumbers.Add(n);
                }
            }

          


            string data = "some data";

            data = data.Encrypt("MD5");
            //data.
            data = MyStringTools.Encrypt(data,"MD5");
            Console.WriteLine(data);
            //data = data.ToUpper();
            //Console.WriteLine(data);
            int a = 23423;
            //a.e
        }
    }

   

    static class MyStringTools
    {
        public static string Encrypt(this object data, string type)
        {
            return "@#$@#$DFER@#$@#RRG@$%R@$R@$RWE@$%@$TRWERT";
        }
    }
}
