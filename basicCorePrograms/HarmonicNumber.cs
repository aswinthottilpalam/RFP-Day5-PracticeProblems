using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCorePrograms
{
    public class HarmonicNumber
    {
        public void HarmonicNumberMethod(int n)
        {
            double result  = 0;
            for (int i = 1; i <= n; i++) 
            {
                result = (result + 1) / i;
            }
            Console.WriteLine($"Harmonic number= {result}");
        }
    }
}
