using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCorePrograms
{
    public class OddOrEven
    {
        public void OddOrEvenMethod(int x)
        {
            Console.WriteLine("Enter the Number: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is an Even number");
            }
            else
            {
                Console.WriteLine($"{x} is an Odd number");
            }

        }
    }
}
