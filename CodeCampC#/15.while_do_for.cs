using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_ {
    internal class @while {
        static void Main(String[] args) {
            int index = 1;

            // in the ( ) u add a condition, and it runs AS LONG AS ITS true
            while (index <= 5) {
                // while loop first checks if the condition is true before doing anything.

                Console.WriteLine(index);
                index++;
            }

            index = 6;


            // in do while loops, you execute the code first and then check the condition.
            do {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);

            // FOR LOOP FOR LOOP FOR LOOP FOR LOOP
            // a type of loop that keeps track of iterations

            // the variable u will iterate on, condition, how much the value changes.
            for (index = 1; index <= 5; index++) {
                Console.WriteLine(index);

            }

            int[] LuckyNumbers = { 3, 6, 8, 10, 23 };

            for (int n = 0; n <= LuckyNumbers.Length; n++) {
                Console.WriteLine(LuckyNumbers[n]);
            }
            
            Console.ReadLine();
        }
    }
}
