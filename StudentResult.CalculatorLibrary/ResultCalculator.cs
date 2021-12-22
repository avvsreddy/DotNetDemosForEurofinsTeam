using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResult.CalculatorLibrary
{
    public class ResultCalculator
    {
        public int FindTotalMarks(params int[] marks)
        {
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            return sum;
        }

        public double FindAverage(params int[] marks)
        {
            int total = FindTotalMarks(marks);
            double average = total / marks.Length;
            return average;
        }

        public string FindResult(double avgMarks)
        {
            string result;
            if (avgMarks >= 60)
                result = "First Class";
            else if (avgMarks >= 50)
                result = "Second Class";
            else if (avgMarks >= 35)
                result = "Pass Class";
            else
                result = "Fail";
            return result;
        }
        

    }
}
