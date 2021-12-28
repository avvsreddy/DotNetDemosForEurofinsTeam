using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{

    //class MyDelegate : MulticastDelegate
    //{

    //}

    delegate void MyDelegate(string abc);
    delegate void MyOtherDelegate(string s, int a);

    

    class Program
    {
        static void Main(string[] args)
        {
            //Greeting("Hello");
            MyDelegate d = new MyDelegate(Greeting);
            Program p = new Program();
            //d += p.Hello;  // subscription
            MyOtherDelegate d2 = new MyOtherDelegate(p.Hello);
            d -= Greeting; // unsub

            //d.Invoke("hello");
            d("hello");
        }

        public static void Greeting(string msg)
        {
            Console.WriteLine("Greeting :" + msg);
        }

        public void Hello(string str,int a)
        {
            Console.WriteLine("Hello :" + str);
        }
    }
}
