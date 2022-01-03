
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MTDemo5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("No. of Cores :" + System.Environment.ProcessorCount);
            Stopwatch w = Stopwatch.StartNew();
            Console.WriteLine("Calling Seq....");
            M1();
            M2();
            Console.WriteLine(w.ElapsedMilliseconds);
            w = Stopwatch.StartNew();
            Console.WriteLine("Calling Parallel...");
            Parallel.Invoke(M1, M2);
            Console.WriteLine(w.ElapsedMilliseconds);
            w = Stopwatch.StartNew();
            Console.WriteLine("Calling Parallel Loop...");
            Parallel.Invoke(M11, M22);
            Console.WriteLine(w.ElapsedMilliseconds);
        }

        static void M1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(100);
            }
        }

        static void M2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(100);
            }
        }

        static void M11()
        {
            //for (int i = 1; i <= 10; i++)
            Parallel.For(1, 101, i =>
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(100);
            });
        }

        static void M22()
        {
            //for (int i = 1; i <= 10; i++)
            Parallel.For(1, 11, i =>
              {
                  Thread.Sleep(100);
              });
        }
    }
}
