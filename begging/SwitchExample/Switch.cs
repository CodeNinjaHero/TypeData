using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begging.SwitchExample
{
    internal class Switch
    {
        public void BasicSwitchExample(char input)
        {
            switch (input)
            {
                case 'a':
                    Console.WriteLine("Seleccionaste la opción A.");
                    break;
                case 'b':
                    Console.WriteLine("Seleccionaste la opción B.");
                    break;
                case 'c':
                    Console.WriteLine("Seleccionaste la opción C.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }


        public void AdvancedSwitchExample(int input)
        {
            switch (input)
            {
                case int n when n < 0:
                    Console.WriteLine("El número es negativo.");
                    break;
                case int n when n == 0:
                    Console.WriteLine("El número es cero.");
                    break;
                case int n when n > 0 && n <= 10:
                    Console.WriteLine("El número está entre 1 y 10.");
                    break;
                case int n when n > 10:
                    Console.WriteLine("El número es mayor que 10.");
                    break;
                default:
                    Console.WriteLine("Entrada no reconocida.");
                    break;
            }
        }

    }
}
