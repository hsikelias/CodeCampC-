using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_
{
    internal class _09
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.WriteLine("MADLIB! PARTY TIME!!" + "\n");

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity name: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Okayyy, let's see what u get");

            Console.WriteLine("Roses are "+ color);
            Console.WriteLine("Violets are "+ pluralNoun);
            Console.WriteLine("I Love "+ celebrity);

        }
    }
}
