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

            List<string> words = new List<string> {"one","two","three","four","five","six" };

            // select all short words (<=3)

            XDocument xmlShortWords = new XDocument(
                new XElement("words", 
                            from w in words
                            where w.Length <= 3
                            select new XElement("word",w)));

            xmlShortWords.Save("d:\\words.xml");

            //foreach (var item in shortWords)
            //{
            //    Console.WriteLine(item);
            //}

            // LINQ to XML

            // Load xml document
            //XDocument xml = XDocument.Load("XMLFile1.xml");

            //var xmlShortWords = from x in xml.Descendants("word")
            //                    where x.Value.Length <= 3
            //                    select x.Value;

            //foreach (var item in xmlShortWords)
            //{
            //    Console.WriteLine(item);
            //}



        }
    }
}
