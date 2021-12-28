using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MTDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Main...Thread ID " + Thread.CurrentThread.ManagedThreadId);
            Stopwatch w = Stopwatch.StartNew();
            Console.WriteLine("Running seq....");
            M1();
            M2();
            Console.WriteLine(w.ElapsedMilliseconds);
            w = Stopwatch.StartNew();
            Console.WriteLine("Running Parallel");
            Parallel.Invoke(M1, M2);
            Console.WriteLine(w.ElapsedMilliseconds);
            Console.WriteLine("Running using Task");
            w = Stopwatch.StartNew();
            Task t1 = new Task(M1);
            t1.Start();
            Task t2 = new Task(M2);
            t2.Start();
            t1.Wait();
            t2.Wait();
            Console.WriteLine(w.ElapsedMilliseconds);


        }

        static void M1()
        {
            Console.WriteLine("In M1...Thread ID " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            //for (int i = 1; i <= 1000; i++)
            //{
            //    Console.WriteLine("M1 : " + i);
            //}
        }
        static void M2()
        {
            Console.WriteLine("In M2...Thread ID " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            //for (int i = 1; i <= 1000; i++)
            //{
            //    Console.WriteLine("M2 : " + i);
            //}
        }
    }
}
