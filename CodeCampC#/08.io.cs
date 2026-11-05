using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_
{
    // class
    class _08
    {
        // Main method
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: "); //prompts user for information.
            string nameInput = Console.ReadLine();
            // essentialy Console.ReadLine is another instruction to the computer which
            // waits for the user to enter something. It also allows user to enter line of
            // text.

            Console.WriteLine("hello " + nameInput + "\a");

            Console.Write("Enter your age:");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine("You are "+age);

            // == > >= < <= != !! &&
            if (age >= 18 && age <= 25)
            {
                Console.Write("You are between 18 and 25!");

            }
            else if (age >= 25)
            {
                Console.WriteLine("You are 25 or older");

            }

            if (age == 18)
            {
                Console.WriteLine("Youa are 18");
            }
        }
    }
}
