using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBindingDemo.Entities
{
    public class Person : INotifyPropertyChanged
    {
        private string name;

        public string Name 
        { 
            get 
            { 
                return name; 
            }

            set 
            {
                name = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        public int Age { get; set; }

        public string Picture { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
