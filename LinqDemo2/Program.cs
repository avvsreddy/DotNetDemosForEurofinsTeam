using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> words = new List<string> {"one","two","three","four","five","six" };
            //// select all short words (<=3)
            //var shortWords1 = from word in words
            //                  where word.Length <= 3
            //                  select word;

            //var shortWords2 = words.Where(w => w.Length <= 3);

            List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9 };
            // select even numbers
            // defers the exe
            //var evens = (from n in numbers where IsEven(n) select n).ToList();
            //numbers.Add(10);
            // display the result
            //foreach (var item in evens)
            //{
            //    Console.WriteLine(item);
            //}


            var evens1 = GetEvens1(numbers);
            var evens2 = GetEvens2(numbers);
            //
            //
            //

            foreach (var item in evens1)
            {

            }

        }

        public static bool IsEven(int n)
        {
            Console.WriteLine("Verifying the number");
            return n % 2 == 0;
        }

        public static IEnumerable<int> GetEvens1(List<int> numbers)
        {
            // defer execution
            var evens = from n in numbers where n % 2 == 0 select n;
            return evens;
        }

        public static List<int> GetEvens2(List<int> numbers)
        {
            // immidiate exe
            var evens = from n in numbers where n % 2 == 0 select n;
            return evens.ToList();
        }
    }
}
