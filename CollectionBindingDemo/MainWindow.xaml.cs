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

namespace CollectionBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<Person> people = new List<Person> 
            {
                new Person{ FirstName = "Sachin", LastName = "Tendulkar", Location="Mumbai"},
                 new Person{ FirstName = "Virat", LastName = "Kholi", Location="Mumbai"},
                  new Person{ FirstName = "Rahul", LastName = "Dravid", Location="Bangalore"},
                   new Person{ FirstName = "Mahendra", LastName = "Dhoni", Location="Ranchi"},

            };

            this.DataContext = people;
            InitializeComponent();
        }
    }
}
