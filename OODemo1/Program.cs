using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemo1
{

    class Calculator
    {
        public double  Sum(double a, double b)
        {
            return a + b;
        }
        //public int Sum(int a, int b)
        //{
        //    return a + b;
        //}
        //public int Sum(int a, int b, int c)
        //{
        //    return a + b + c;
        //}
        public int Sum(int a=0, int b=0, int c=0, int d=0)
        {
            return a + b + c + d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism

            // Static / Compile Time - Method Overloading - differnt method signature - same class

            // Dynamic / Runtime - Method Overriding - same method sign - base-deried

            // Base class referece variable can hold derived type object

            List<Employee> empList = new List<Employee>();

            Employee e = new Employee();
            e.Name = "Ravi";
            e.BasicSalary = 50000;
            e.HRA = 10000;

            empList.Add(e);
           
            Employee e2 = new SalesPerson();
            e2.Name = "Rohit";
            e2.BasicSalary = 60000;
            e2.HRA = 15000;

            empList.Add(e2);

            PaySalary(empList);

        }

        public static void PaySalary(List<Employee> employees)
        {
            foreach (var e in employees)
            {
                e.CalculateSalary();
            }
        }
    }
}
