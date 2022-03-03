using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCorePrograms
{
    public class CoinFlip
    {
        int headCount = 0;
        int tailCount = 0;
        public void CoinFlipMethod(int userinput)
        {
            Random r = new Random();
            while (userinput != 0)
            {
                double random=r.NextDouble();
                {
                    if (random <= 0.5)
                    {
                        tailCount = tailCount + 1;
                    }
                    else
                    {
                        headCount++;
                    }
                }
                userinput = userinput - 1;
            }

            Console.WriteLine((headCount * 100) / userinput);
            Console.WriteLine((tailCount * 100) / userinput);
        }
    }
}
