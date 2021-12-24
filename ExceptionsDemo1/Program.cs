using ExceptionsDemo1.BusinessLayer;
using ExceptionsDemo1.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            // want to accept two ints and find the sum repeatdly

            int fno;
            int sno;
            int sum;
            while (true)
            {
                try
                {
                    Console.Write("Enter First Number: ");
                    fno = int.Parse(Console.ReadLine());
                    Console.Write("Enter Second Number: ");
                    sno = int.Parse(Console.ReadLine());
                    Calculator calc = new Calculator();
                    sum = calc.Sum(fno, sno);
                    Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter only interger number");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Kindly enter small int numbers only");
                }

                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                }                //catch (Exception ex) // catch all 
                                 //{
                                 //    Console.WriteLine(ex.Message);

                //}
            }

        }
    }
}
