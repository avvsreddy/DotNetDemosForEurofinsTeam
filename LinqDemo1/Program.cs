using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Linq to Objects

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> numberlist = new List<int> {11,12,53,24,65,16,7,89,90 };

            // sql select -> select number from numberslist where number mod 2 = 0 order by number desc;

            // using linq expressions - sql select

            List<int> evenNumbers = new List<int>();
            foreach (var item in numberlist)
            {
                if (item % 2 == 0)
                    evenNumbers.Add(item);
            }

            var evens1 = from n in numberlist
                         where n % 2 == 0
                         orderby n descending
                         select n;

            var evens55 = numberlist.Where(n => n % 2 == 0).OrderByDescending(n=>n);

            // using extension methods

            Func<int, bool> predicate = new Func<int, bool>(IsEven);
            var evens2 = numberlist.Where(predicate);
            var evens3 = numberlist.Where(delegate (int n){
                return n % 2 == 0;
            });
            var evens4 = numberlist.Where((int n) => {
                return n % 2 == 0;
            });
            var evens5 = numberlist.Where(n => n % 2 == 0 );

            foreach (var item in evens2)
            {
                Console.WriteLine(item);
            }

            // Linq to XML
            // Linq to Entities

        }

        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
