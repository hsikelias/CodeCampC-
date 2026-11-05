using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_
{
    internal class _10
    {
        static void Main(string[] args)
        {
            // variables can only store a single value and when dealing with huge information,
            // it is not convinient to make 100s of variables.. arrays though u can store 100s 1000s
            // in one variable




            // 1. first specify the data type that will be stored in the array
            // 2. we tell C# you're tryna store an array is through [] after specifying data type.
            // 3. { } curly brackets in which u write the 'elements' of the array.
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            string[] emptyArrayTest = { };
            // u might think this is just creating an empty array that u can add on later.. but
            // the ln25 says literally make the size of this array 0 and u cannot add data to this
            // later on. If u wanna create an empty array but add later u NEED to specify the size, ts is one way
            string[] friends = new string[10];

            friends[0] = "Kelly";
            friends[1] = "Roman";


            Console.WriteLine(luckyNumbers[0]); // returns the first position, in this case 4.

            luckyNumbers[1] = 5; // changes the value in this index position.

            Console.ReadLine();
        }
    }
}
