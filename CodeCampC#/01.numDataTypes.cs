using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_{
    internal class _01{
        // main entry point to the code, .NET framework requires this to run C# console app

        int x, y, z;

        // Static void Main is inside the class Program and the class is inside namespace CodeCampC_
        static void Main(string[] args){
            Console.WriteLine("Hello world"); // this is using System, which we called for in L1

            int age = 23; //initializing and declaring in the same line
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            
            long bigNumber = 1000000L;
            // to tell the compiler you want to process this as a long number u need to specify the data
            // type in the end, by default for any int u enter it assumes its int32. 
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);


            double negative = -55.2d; // if it has a . compiler always registers it as a double
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 5.00001f;
            // default compiler registers as a double, enter f in the end to define what it actually is.



            // float 32bit, double 8 bytes, decimal 16 bytes.
            decimal money = 14.88M;
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);


            Console.ReadLine();
        }
    }
}
