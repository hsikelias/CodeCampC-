using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_
{
    internal class _05
    {

        static void Main(String[] args)
        {
            int age = 23;

            age++; // increments age by 1
            Console.WriteLine(age);

            age--; // decrements age by 1
            Console.WriteLine(age);

            age += 1; // this is exactly the same thing as age++ or age = age+1


            age = 23;
            age *= 10; // age will now be 230
            Console.WriteLine(age);

            age = 23;
            age /= 10; // this wont be 2.3, it gets rounded to 2 because age is an INT

            // use double instead if the decimal points matter


            // ++i and i++ do things differently
            // in the first option, u increment before returning i



            // MODULOUS =  REMAINDER // REMAINDER // REMAINDER 
            int firstNum = 3;
            int secondNum = 10;

            int answer = secondNum%firstNum;
            Console.WriteLine(answer); // remainder = 1 

            // to determine if a number is even/odd we can divide it by 2

            Console.ReadLine();
        }
    }
}
