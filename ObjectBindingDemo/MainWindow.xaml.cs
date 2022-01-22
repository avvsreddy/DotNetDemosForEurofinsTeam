using ObjectBindingDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ObjectBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            Person p = new Person { Name = "Sachin", Age = 40, Picture = "Images\\Sachin.jpg" };
            this.DataContext = p;

            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string nameinTextBox = textBox.Text;

            string nameinObject = ((Person)DataContext).Name;

            MessageBox.Show($"Name in TextBox :{nameinTextBox} \n Name in Object {nameinObject} ");

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ((Person)DataContext).Name = "Sachin Tendulkar";
            MessageBox.Show("Name changed in object");
        }
    }
}
