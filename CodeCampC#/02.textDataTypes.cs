using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_{
    internal class _02{
        static void Main(string[] args){

            string name = "Text";
            char letter = 'A';

            Console.Write(letter);
            Console.Write(name);

            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());

            Console.WriteLine(name.Contains('a')); // should return false.

            Console.WriteLine(name[0]);
            Console.WriteLine(name.IndexOf("ext")); // provides index location of where the given
            // character firs appears, if you get -1 it means it doesnt exist.

            Console.WriteLine(name.Substring(1,2));
            // this returns part of a string, in this case start at index 1 and if u dont add the comma it
            // returns till the end of the character.. but u can also specify how many characters u want in
            // return.  In our case we should be getting "ex"
        }
    }
}
