using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // find sum
            int fno = int.Parse(textBox1.Text);
            int sno = int.Parse(textBox2.Text);
            int sum = calc.FindSum(fno, sno);
            MessageBox.Show($"The sum of {fno} and {sno} is {sum}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // subtraction
            int fno = int.Parse(textBox1.Text);
            int sno = int.Parse(textBox2.Text);
            int result = calc.FindDifference(fno, sno);
            MessageBox.Show($"The difference of {fno} and {sno} is {result}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // multiplication
            int fno = int.Parse(textBox1.Text);
            int sno = int.Parse(textBox2.Text);
            int result = calc.FindProduct(fno, sno);
            MessageBox.Show($"The product of {fno} and {sno} is {result}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // division
            int fno = int.Parse(textBox1.Text);
            int sno = int.Parse(textBox2.Text);
            double result = calc.Divide(fno, sno);
            MessageBox.Show($"The division of {fno} and {sno} is {result}");
        }
    }
}
