using System;

namespace basicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            CoinFlip f = new CoinFlip();
            f.CoinFlipMethod(number);

          

        }
    }
}
