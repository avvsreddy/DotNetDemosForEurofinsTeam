using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // want to store n number of int and read
            List<int> ints = new List<int>();
            ints.Add(10);
            ints.Add(20);

          

            // want to store n number of names and read


            // want to store n number of floats and read

            DynamicArray<float> floadData = new DynamicArray<float>();
            floadData.Add(10.9f);
           

            StringDynamicArray names = new StringDynamicArray();
            names.Add("aaaa");
            names.Add("bbbb");

            for (int i = 0; i < names.Size; i++)
            {
                Console.WriteLine(names.Get(i));
            }

            IntDynamicArray array = new IntDynamicArray();
            array.Add(10);
            array.Add(20);
            array.Add(10);
            array.Add(20);
           


            for (int i = 0; i < array.Size; i++)
            {
                Console.WriteLine(array.Get(i));
            }


        }
    }


    internal class DynamicArray<replace> // Generic Class
    {
        private replace[] data = new replace[4];
        private int index = 0;
        public int Size
        {
            get { return index; }
        }

        internal void Add(replace v)
        {
            if (index >= data.Length) // resize
            {
                Array.Resize(ref data, data.Length * 2);
            }
            data[index++] = v;
        }

        internal replace Get(int i)
        {
            return data[i];
        }
    }

    internal class DoubleDynamicArray
    {
        private double[] data = new double[10];
        private int index = 0;
        public int Size
        {
            get { return index; }
        }

        internal void Add(double v)
        {
            if (index >= data.Length) // resize
            {
                Array.Resize(ref data, data.Length * 2);
            }
            data[index++] = v;
        }

        internal double Get(int i)
        {
            return data[i];
        }
    }


    internal class StringDynamicArray
    {
        private string[] data = new string[10];
        private int index = 0;
        public int Size
        {
            get { return index; }
        }

        internal void Add(string v)
        {
            if (index >= data.Length) // resize
            {
                Array.Resize(ref data, data.Length * 2);
            }
            data[index++] = v;
        }

        internal string Get(int i)
        {
            return data[i];
        }
    }

    class IntDynamicArray
    {

        private int[] data = new int[10];
        private int index = 0;
        public int Size
        {
            get { return index; }
        }

        internal void Add(int v)
        {
            if( index >= data.Length ) // resize
            {
                Array.Resize(ref data, data.Length * 2);
            }
            data[index++] = v;
        }

        internal int Get(int i)
        {
            return data[i];
        }
    }
}
