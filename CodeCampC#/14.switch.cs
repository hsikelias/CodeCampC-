using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_ {
    internal class _14 {

        static void Main(String[] args) {
            Console.WriteLine(GetDay(10));
            Console.ReadLine();
        }

        static string GetDay(int dayIndex) {
            string dayName;
            
            // switch needs a value to compare to different thins
            switch (dayIndex) {
                case 0: // in the case dayNum value is 0, we do this that is set dayName to "Sunday"
                    dayName = "Sunday";
                    break; // if we dont add the break, C# will keep chechking the other cases
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number (0-6 only)";
                    break;
            }

            return dayName;
        }
    }
}
