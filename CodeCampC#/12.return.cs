using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_
{
    internal class _12
    {
        static void Main(String[] args)
        {
            // return: a keyword that is used to return values to the callers
            Console.WriteLine(CubeIt(5));
            IfStatemenets();
            
            Console.ReadLine();
        }
        


        // -------------------------------------------------------------------------------------- //



        // we're writing a method called 'CubeIt' that will cube a given number and it will be an int
        static double CubeIt(int num)
        {
            double result = Math.Pow(num, 3);
            return result;
        }



        // -------------------------------------------------------------------------------------- //



        static void IfStatemenets()
        {
            bool isMale = false;
            bool isTall = true;

            // inside the parantehsese we write the condition of this if statement.
            if (isMale && isTall) { // return true
                Console.WriteLine("You are a tall male!");
            }
            else if (isMale || isTall){ // return true but this won't be executed because the if statement is true
                Console.WriteLine("You are either a male or tall");
            }
            else
            {
                Console.WriteLine("You are not male or not tall!");
            }
        }



        // -------------------------------------------------------------------------------------- //
    }
}
