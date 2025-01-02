using Begging.Interface;

namespace Begging.Inheritance
{
    internal class Calculator : HightOpe, Operations
    {
        public Calculator(int num) : base(num)
        { }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subs(int a, int b)
        {
            return a - b;
        }

    }
}
