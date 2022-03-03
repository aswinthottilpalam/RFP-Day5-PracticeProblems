using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCorePrograms
{
    public class SwapTwoNum
    {
        public void SwapTwoNumMethod(int userinput)
        {
            int num1, num2, temp;
            Console.WriteLine("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After swapping First number is: {num1}");
            Console.WriteLine($"After swapping Second number is: {num2}");
        }
    }
}
