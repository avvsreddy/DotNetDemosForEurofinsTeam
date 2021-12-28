namespace StudentResult.CalculatorLibrary
{
    public class ResultCalculator
    {
        INotification notification = null;

        public ResultCalculator()
        {
            notification = new MailNotification();
        }

        public ResultCalculator(INotification notification)
        {
            this.notification = notification;
        }

        public int FindTotalMarks(params int[] marks)
        {
            if (marks == null || marks.Length == 0)
            {
                throw new InvalidMarksException("Makrs are empty, kindly provide the marks");
            }

            foreach (var m in marks)
            {
                if (m < 0 || m > 100)
                    throw new InvalidMarksException("Marks should be in between 0 to 100 only");
            }

            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            return sum;
        }



        // Test Case 1: ValidInput_ValidOutput
        // Test Case 2: 
        // Test Case 3: 
        public double FindAverage(params int[] marks)
        {
            int total = FindTotalMarks(marks);
            double average = total / marks.Length;
            return average;
        }


        // CAse 1: ForAvg60AndAbobe_ShouldReturnFirstClass
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

            // send mail
         
            notification.Notify(result);

            // Mock TEsting

            return result;
        }


    }

   
}
