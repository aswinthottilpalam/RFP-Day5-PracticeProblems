using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCorePrograms
{
    public class LeapYear
    {
        public void LeapYearMethod(int userinput)
        {
            Console.WriteLine("Enter Year: ");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine($" {Year} This year is a Leap Year");
            }
            else
            {
                Console.WriteLine($"{Year} This Year is not a Leap Year");
            }
        }
    }
}
