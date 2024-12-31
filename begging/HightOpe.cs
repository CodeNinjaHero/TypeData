using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begging
{
    internal class HightOpe
    {
        public HightOpe(int number) { }
        public int Sqr(int x) {
            return (int)Math.Sqrt(x);
        }
        public int Factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }

    }
}
