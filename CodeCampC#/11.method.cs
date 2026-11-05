using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_

{
    internal class _11
    {
        // Main is a method, this a method that gets executed when u run a program.
        static void Main(string[] args)
        {
            SayHi("Mike"); // C# jumps to the SayHi method


            // Methods = little block of codes that perform a specific task.
        }

        // CREATING METHODS
        // keyword
        // return types; void means this method won't return anything.
        // method name


        // the 'SayHi' method doesn't run automatically.. we need to call the method manually.
        // inside the ( ) of a method we can provide information this method needs called Parameters/Arguments
        static void SayHi(string name) // now sayHi method needs to take a string as a parameter, so when
            // we call this method, need to provide a value that satisfies this data type condition.
        {
            Console.WriteLine("Hello "+name);
            Console.ReadLine();
            SayHi("Mike2"); // infinite loop lol
        }
    }
}
