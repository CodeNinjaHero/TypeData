using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begging
{
    internal class Calculator : HightOpe, Operations
    {
        public Calculator(int num) : base(num)
        { }
        public int Add(int a, int b) {
            return a + b;
        }

        public int Subs(int a, int b) {
            return a - b;
        }
    }
}
