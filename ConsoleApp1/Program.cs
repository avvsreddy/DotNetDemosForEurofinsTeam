using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace ConsoleApp1
{
    // UI Logic
    class Program 
    {
        //static Calculator  theCalc = new Calculator();  // Has-A
        // UI Logic
        static void Main(string[] args) // SRP
        {
            Calculator theCalc = new Calculator(); // Uses
            // Accept two ints, find the sum then display the result
            int fno;
            int sno;
            int sum = 0;

            Console.Write("Enter First Number: ");
            fno = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            sno = int.Parse(Console.ReadLine());


            sum = theCalc.FindSum(fno, sno);
            //sum = FindSum(fno, sno);

            Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
        }

      
    }

   

    
}

