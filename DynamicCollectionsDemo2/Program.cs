using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCollectionsDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // store and ready randomly
            List<int> numbers = new List<int>(); // dynamic typed collection

            // dynamic untyped collections

            ArrayList list = new ArrayList();
            list.Add(100);
            list.Add("100");
            list.Add(true);

            int x = (int)list[0];

          //System.Collections.Concurrent.ConcurrentStack<int>

            //numbers.Add(10);
            //numbers.Add(10);
            //numbers.Add(10);
            //numbers.Add(10);
            //numbers.Add(10);
            //Console.WriteLine(numbers.Count);
            //numbers.TrimExcess();
            //Console.WriteLine(numbers.Capacity);
            //Console.WriteLine(numbers.Sum());
            //Console.WriteLine(numbers.Average());
            //Console.WriteLine(numbers.Max());
            //Console.WriteLine(numbers.Min());

            //// stack

            //Stack<int> stack = new Stack<int>();
            //// add
            //stack.Push(100);
            //// read
            //int a = stack.Pop(); // reads and deletes
            //a = stack.Peek();//only reads

            //// Queue

            //Queue<int> q = new Queue<int>();
            //// add
            //q.Enqueue(100);
            //// read
            //a = q.Dequeue(); // reads and deletes
            //a = q.Peek(); // reads

            //// Uniq data only

            HashSet<int> unique = new HashSet<int>();
            unique.Add(10);
            unique.Add(10);

            Console.WriteLine(unique.Count);

            foreach (var item in unique)
            {
                Console.WriteLine(item);
            }

            // store student roll number with result
            Dictionary<int, string> results = new Dictionary<int, string>();
            results.Add(111, "Pass");
            results.Add(456, "Fail");

            string res = results[456];

            

        }
    }
}
