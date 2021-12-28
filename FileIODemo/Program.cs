using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //WriteToFile();
            //ReadFromFile();
            //ProcessItems();
            //List<Item> items = GetAllItems();
            //foreach (var item in items)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Console.WriteLine("Total Count of items is " + items.Count);
            //Console.WriteLine("Total Worth of items is " + items.Sum(SumOnPrice));
            //Console.WriteLine("Total Worth of items is " + items.Sum(i=>i.Price));
            //Func<Item, int> func = new Func<Item, int>(SumOnPrice);
            //Console.WriteLine("Total Worth of items is " + items.Sum(func));

            //ListAllFileNames();

            // get all dirves
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                Console.WriteLine(item.Name);
            }

            File.Delete("abc");
            File.Exists("abc");

        }


        public static void ListAllFileNames()
        {
            string[] fileNames = Directory.GetFiles("D:\\");
            foreach (var f in fileNames)
            {
                FileInfo fileInfo = new FileInfo(f);
                
                Console.WriteLine($"{f}\t{fileInfo.Length}" );
            }
        }

       
        public static int SumOnPrice(Item item)
        {
            return item.Price;
        }

        public static void IncreaseProductsPrice()
        {
            // increase all products price to 1000 and save into new file;
        }


        public static void ReadFromFile()
        { 
            StreamReader reader = null;
            string allLines;
            try
            {
                reader = new StreamReader("d:\\sample.txt");
                //allLines = reader.ReadToEnd();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            finally
            {
                reader.Close();
            }
            //Console.WriteLine(allLines);


        }
        public static void WriteToFile()
        {
            string data = "This is simple data line 3";
            StreamWriter streamWriter = null;
            // write into file
            try
            {
                streamWriter = new StreamWriter("d:\\sample.txt", true);
                streamWriter.WriteLine(data);
                //
                //
                //

            }
            finally
            {
                streamWriter.Close();
            }


        }

        public static void ProcessItems()
        {
            int productsCount = 0;
            int totalAmount = 0;

            StreamReader reader = new StreamReader("d:\\item.txt");
            while (!reader.EndOfStream)
            {
                string itemLine = reader.ReadLine();
                productsCount++;
                string[] item = itemLine.Split(',');
                totalAmount += int.Parse(item[2]);
            }
            reader.Close();
            Console.WriteLine("The Items count :" + productsCount);
            Console.WriteLine("The Total Cost :" + totalAmount);
        }

        public static List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();

            StreamReader reader = new StreamReader("d:\\item.txt");
            while (!reader.EndOfStream)
            {
                Item item = new Item();
                string itemLine = reader.ReadLine();
                string[] itemData = itemLine.Split(',');
                item.ItemID = int.Parse(itemData[0]);
                item.Name = itemData[1];
                item.Price = int.Parse(itemData[2]);
                items.Add(item);
            }
            reader.Close();


            return items;
        }
    }

    class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
