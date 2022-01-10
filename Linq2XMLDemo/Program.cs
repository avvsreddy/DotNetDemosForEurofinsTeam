using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq2XMLDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // load xml document
            var xml = XDocument.Load("d:\\products.xml");

            // Lab 1: select all product names from xml docu

            var lab1 = from p in xml.Descendants("Product")
                       select new { Name = p.Element("Name").Value, Rate = p.Element("Price").Value };



        }
    }
}
