using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_{
    internal class _03{
        static void Main(String[] args)
        {
            // converting from string to int

            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);


            string textBigNumber = "100023232";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            string textPrecision = "5.00001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);


            Console.ReadLine();
            

        }
    }
}
