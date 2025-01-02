using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begging.Loops
{
    internal class LoopsExample
    {
        public void ExFor()
        {
            int[] arrayInt = { 1, 2, 3 };
            // Bucle `for`
            Console.WriteLine("Bucle for:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }           
        }
        public void ExForEach()
        {
            int[] arrayInt = { 1, 2, 3 };
            // Bucle `foreach`
            Console.WriteLine("Bucle foreach:");
            foreach (var i in arrayInt)
            {
                Console.WriteLine(i);
            }

        }
        public void ExWhile()
        {
            // Bucle `while`
            Console.WriteLine("Bucle while:");
            bool flag = true;
            var count = 0;
            while (flag)
            {
                Console.WriteLine(count);
                count++;
                if (count > 5)
                {
                    flag = false;
                }
            }
        }
        public void ExDoWhile()
        {
            // Bucle do- while
            int count2 = 0;

            Console.WriteLine("Bucle do-while:");
            do
            {
                Console.WriteLine($"El valor de count es: {count2}");
                count2++;
            }
            while (count2 < 5);

            Console.WriteLine("El bucle do-while ha terminado.");
        }
    }
}
