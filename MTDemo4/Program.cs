using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MTDemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            LargeData largeData = new LargeData();
            //Parallel.Invoke(largeData.Fill, largeData.Fill); ;
            //Task t1 = new Task(largeData.Fill);
            //t1.Start();
            //Task t2 = new Task(largeData.Fill);
            //t2.Start();

            //t1.Wait();
            //t2.Wait();

            Thread t1 = new Thread(largeData.Fill);
            t1.Start();

            Thread t2 = new Thread(largeData.Fill);
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine(largeData.data.Count);
        }
    }




   
    class LargeData
    {
        //public Stack<int> data = new Stack<int>();
        public ConcurrentStack<int> data = new ConcurrentStack<int>();

        //[MethodImpl(MethodImplOptions.Synchronized)]
        public void Fill()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                //Monitor.Enter(this);
                //lock (this)
                //{
                    data.Push(i);
                //}
                //Monitor.Exit(this);

                // Semaphore
                // Mutex

            }
        }
    }
}
