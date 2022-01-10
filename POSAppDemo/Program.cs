using System;
using System.Collections.Generic;
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
            ITaxCalculator taxCalculator = new APTaxCalculator();
            double taxAmt = taxCalculator.CalculateTax(amount);
            // 5. generate the bill
            // 6. process the payment
        }
    }


    class TaxCalculatorFactory
    {
        public ITaxCalculator CreateTaxCalculator(string state)
        {
            if (state == "KA")
                return new KATaxCalculator();
            else if (state == "AP")
                return new APTaxCalculator();
            else if (state == "TN")
                return new TNTaxCalculator();
            else
                return null;
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
