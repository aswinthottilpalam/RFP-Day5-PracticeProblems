using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCorePrograms
{
    public class QuotientRemainder
    {
        public void QuotientRemainderMethod(int userinput)
        {
            int x, y, r, q;
            Console.WriteLine("Enter First Number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second NUmber: ");
            y = Convert.ToInt32(Console.ReadLine());

            q = x / y;
            r = x % y;

            Console.WriteLine($"Quotient is: {q}");
            Console.WriteLine($"Remainder is: {r} ");
        }
    }
}
