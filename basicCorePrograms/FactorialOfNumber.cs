using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCorePrograms
{
    public class FactorialOfNumber
    {
        public void factorialOfNumber(int n)
        {
            int result = 1;
            while (n != 0)
            {
                result *= n;
                n--;
            }
            Console.WriteLine($"Factorial of the number is: {result}");
        }
    }
}
