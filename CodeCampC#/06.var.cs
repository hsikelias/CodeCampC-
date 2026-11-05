using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_
{
    internal class _06
    {
        static void Main(string[] args)
        {
            // compiler figure outs what type it needs based on the initializaed value.


            // int 32 
            var age = 23;
            Console.WriteLine(age);

            // need to add L to say its int 64 bit
            var bigNumber = 9000000L;
            Console.WriteLine(bigNumber);
            
            // the D specifies its a double
            var negative = -23.2D;
            Console.WriteLine(negative);
    
            // the f turns it into a single, a float
            var precision = 5.000001f;
            Console.WriteLine(precision);

            // the M turns it into a decimal
            var money = 14.59m;
            Console.WriteLine(money);

            var name = "aba";
            // string

            var letter = 'a';
            // char

            // use var when the variable data type is really obvious with its name.
        }
    }
}
