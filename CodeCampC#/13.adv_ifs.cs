using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_{

    internal class _13{

        static void Main(String[] args){
            Console.WriteLine(GetMax(10, 12, 7));
            Console.ReadLine();
        }
                            // 5   6    7
        static int GetMax(int num1, int num2, int num3) {
            int result;

            if (num1 >= num2 && num1 >= num3) {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3) {
                result = num2;
            }
            else {
                result = num3;
            }
            return result;
        }
        
    }
}
