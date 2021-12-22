using System;

namespace OODemo1
{
    // Generalization - Realization
    abstract class SalesPerson : IEmployee
    {

        int _baadfasdfasdf;
      public int EmpID { get { return _baadfasdfasdf; } set { _baadfasdfasdf = value; } }
      public string Name { get; set; }
      public int BasicSalary { get; set; }
      public int HRA { get; set; }
        public int Bonus { get; set; }

         public int CalculateSalary()
        {
            Console.WriteLine("Calculating Sales Person Salary");
            return BasicSalary + HRA + Bonus;
        }

       abstract public void Promote();
        
    }
}
