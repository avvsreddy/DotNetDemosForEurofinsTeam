using StudentResult.CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentResult.DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            int s1Marks = int.Parse(txtSubject1Marks.Text);
            int s2Marks = int.Parse(txtSubject2Marks.Text);
            int s3Marks = int.Parse(txtSubject3Marks.Text);
            //int[] marks = new int[3];
            //marks[0] = s1Marks;
            //marks[1] = s2Marks;
            //marks[2] = s3Marks;
            ResultCalculator calc = new ResultCalculator();
            txtTotalMarks.Text = calc.FindTotalMarks(s1Marks,s2Marks,s3Marks).ToString();
            double avg = calc.FindAverage(s1Marks, s2Marks, s3Marks);
            txtAverageMarks.Text = avg.ToString();
            txtResult.Text = calc.FindResult(avg);
        }
    }
}
