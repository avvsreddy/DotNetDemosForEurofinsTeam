using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(M1);
            t1.Start();

            Task t2 = new Task( ()=> { M2(100); }   );
            t2.Start();

            Task<int> t3 = new Task<int>(M3);
            t3.Start();

            int res = t3.Result;

            Task<int> t4 = new Task<int>( ()=> { return M4(100); });

            t4.Start();
            res = t4.Result;


        }




        static void M1()
        {

        }

        static void M2(int a)
        {
            
        }

        

        static int M3()
        {
            return 100;
        }

        static int M4(int a)
        {
            return a;
        }
    }
}
