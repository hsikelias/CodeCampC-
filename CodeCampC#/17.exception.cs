using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_ {
    internal class _17 {

        static void Main(String[] args) {
            // exceptions are very common in programming and C# has features that allow us to
            // write code to handle these exceptions without crashing the program.

            // essentially this featuer lets us to allow the program still running even when an exception is thrown.

            // POSSIBLE ERRORS
            // in the below program, what if the user enters an alphabetical input, that would throw an "System.FormatException"
            // what if the user divides a number by 0.


            // UNSAFE CODE, 
            //Console.WriteLine("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            
            // now program will try the code in the 'try' block and then if a particular exception is thrown
            // it moves to execute the code inside catch.

            try {
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

            }
            catch(DivideByZeroException e) {
                /* we can write multiple catch statements to define a particualr exception we're looking for.
                 * 
                 * example:
                 *      
                 *      catch(DivideByZeroException){
                 *      
                 *      }
                 *      
                 * or u can stick to having one catch handle ALL exceptions
                 */

                Console.WriteLine(e.Message);
                // u can see the actual error that's causing problem without breaking the program.
            }
            catch(FormatException) {
                Console.WriteLine("bumass provide a number!!");
            }
            finally {
                // anything inside this codeblock is going to get executed no matter what.
            }

        

            Console.ReadLine();
        }
    }
}
