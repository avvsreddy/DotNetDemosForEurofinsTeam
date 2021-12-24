using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo1
{
    class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // single dimentional arrays
            int[] numbers1 = new int[5] {1,2,3,4,5 };
            int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };
            int[] numbers3 = { 1, 2, 3, 4, 5 };

            object[] test = new object[5] {1,"ten",true,50.3,5 };

            // 2d,3d,nd
            // 2 d

            int[,] twodarray = new int[5, 3] { {1,2,3 },{1,2,3 },{1,2,3 },{1,2,3 },{1,2,3 } };

            // Jogged Arrays 
            int[][] scores = new int[5][];
            scores[0] = new int[3];
            scores[1] = new int[2];
            scores[2] = new int[1];
            scores[3] = new int[5];
            scores[4] = new int[6];

            scores[1] [0] = 10; 

        }
    }
}
