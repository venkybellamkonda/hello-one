using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public Class1() { }
        public void calculateSum(int x, int y)
        {
            int z = x + y;
            Console.WriteLine(z);
        }

        public void calculateSqrt(double x)
        {
            double z = Math.Sqrt(x);
            Console.WriteLine(z);
        }

    }
}
