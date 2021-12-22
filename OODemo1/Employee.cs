using System;

namespace OODemo1
{
    interface IEmployee
    {

        
          int EmpID { get ; set; }
         string Name { get; set; }
         int BasicSalary { get; set; }
         int HRA { get; set; }

         int CalculateSalary();
        //{
            //Console.WriteLine("Calculating Employee Salary");
            //return BasicSalary + HRA;
        //}

         void Promote();
       
    }
}
