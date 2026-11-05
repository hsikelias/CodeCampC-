using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_ {
    internal class _16 {
        static void Main(String[] args) {

            // 2 dimensional arrray = when every element inside of an array is an array.

            // the , inside [] tells C# its a 2d array
            int[,] numberGrid = {

                // 3 elements and 2 elements inside of them.
                {1,2 },
                {3,4 },
                {5,6 },
            };
            

            // 3 dimension
            int[,,] numberGrid2 = {
                {
                    {1,2,3 },
                    {4,5,6 },
                },

                {
                    {7,8,9},
                    {10,11,12 },
                },

            };
                                      //  row,column
            Console.WriteLine(numberGrid2[1,1,1]); // should print 11

            int[,] myArray = new int[2, 3];
            // tells C# ow many rows and how many columns we need to have..
            // so, in this case 2 array elemnts and inside them 3 array elements/

        }
    }
}
