using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            POSBillingSystem billingSystem = new POSBillingSystem();
            billingSystem.GenerateBill("TN");
            Console.ReadLine();
        }
    }


    class POSBillingSystem
    {
        public void GenerateBill(string state)
        {
            // 1. calculate the total amount
            int amount = 2300;
            // 2. calculate the discount
            // 3. apply any coupns
            // 4. calculate the sales tax
            TaxCalculatorFactory factory1 = new TaxCalculatorFactory();
            Console.WriteLine("Factory 1" + factory1.GetHashCode());

            TaxCalculatorFactory factory2 = new TaxCalculatorFactory();
            Console.WriteLine("Factory 2" + factory2.GetHashCode());

            //ITaxCalculator taxCalculator = factory.CreateTaxCalculator();
            //ITaxCalculator taxCalculator = TaxCalculatorFactory.CreateTaxCalculator();
            //double taxAmt = taxCalculator.CalculateTax(amount);
            // 5. generate the bill
            // 6. process the payment
        }
    }


    class TaxCalculatorFactory
    {
        public virtual ITaxCalculator CreateTaxCalculator()
        {
            string taxCalcClass = ConfigurationManager.AppSettings["TAXCALC"];
            // use reflextion
            Type theType = Type.GetType(taxCalcClass);
            ITaxCalculator taxCalculator= (ITaxCalculator)Activator.CreateInstance(theType);
            return taxCalculator;
        }
    }

    interface ITaxCalculator
    {
        double CalculateTax(double amount);
    }

    class KATaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double amount)
        {
            double taxAmt = 0;
           
            int cst = 50;
            int kst = 50;
            int es = 5;
            int kkt = 2;
            Console.WriteLine("Using KA Tax Calculator");
            taxAmt = cst + kst + es + kkt;
            
            return taxAmt;
         
        }
    }

    class TNTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double amount)
        {
            double taxAmt = 0;
           
            int cst1 = 50;
            int tst1 = 50;
            int abc = 5;
            int xyz = 2;
            Console.WriteLine("Using TN Tax Calculator");
            taxAmt = cst1 + tst1 + abc + xyz;
            
            return taxAmt;

        }
    }

    class APTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double amount)
        {
            double taxAmt = 0;

            int cst1 = 50;
            int tst1 = 50;
            int abc = 5;
            int xyz = 2;
            Console.WriteLine("Using AP Tax Calculator");
            taxAmt = cst1 + tst1 + abc + xyz;

            return taxAmt;

        }
    }


}
