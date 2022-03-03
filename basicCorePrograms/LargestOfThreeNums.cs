using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCorePrograms
{
    public class LargestOfThreeNums
    {
        public void LargestOfThreeNumsMethod(int userinput)
        {
            int num1, num2, num3;
            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine($"{num1} is the largest amoung three numbers");
            }
            else if (num2 > num3)
            {
                Console.WriteLine($"{num2} is the largest amoung three numbers");
            }
            else
            {
                Console.WriteLine($"{num3} is the largest amoung three numbers");
            }
        }
    }
}
