using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCorePrograms
{
    public class PowerOfTwo
    {
        public void PowerOfTwoMethod(int n)
        {
            int temp = n;
            int result = 1;
            while(n!=0)
            {
                result *= 2;
                n--;
            }
            Console.WriteLine($"Power of 2 ^ {temp} is: {result}");
        }
    }
}
