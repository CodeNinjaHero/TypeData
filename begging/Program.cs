using System;
using System.Collections.Generic;
using System.Text;

namespace begging
{
    public class Begging
    {
        public static void Main(string[] arr)
        {
            // Llamamos a las funciones
            ShowBasicVariables();
            DemonstrateLoops();
            WorkWithListsAndObjects();
            UseCalculator();
            BasicSwitchExample('a');
            AdvancedSwitchExample(5);
        }

        // Función para mostrar variables básicas
        public static void ShowBasicVariables()
        {
            int num = 10;
            float f = 14.2f;
            char ch = 'a';
            decimal de = 0;
            long lg = 0;
            string str = "dsadas";
            StringBuilder strBul = new StringBuilder("hola");

            Console.WriteLine($"Variables: int={num}, float={f}, char={ch}, " +
                $"decimal={de}, long={lg}, string={str}, StringBuilder={strBul}");
        }

        // Función para demostrar bucles `for`, `foreach`, `while` y do-while
        public static void DemonstrateLoops()
        {
            int[] arrayInt = { 1, 2, 3 };

            // Bucle `for`
            Console.WriteLine("Bucle for:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Bucle `foreach`
            Console.WriteLine("Bucle foreach:");
            foreach (var i in arrayInt)
            {
                Console.WriteLine(i);
            }

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


        // Función para trabajar con listas y objetos
        public static void WorkWithListsAndObjects()
        {
            // Lista genérica
            List<int> lst = new List<int>();
            lst.Add(1);

            // Lista de cervezas
            var beers = new List<Beer>
            {
                new Beer("Corona", "Desconocido"),
                new Beer("La mal portada", "Desconocido"),
                new Beer("Ron del caldas", "Desconocido")
            };

            Console.WriteLine("Lista de cervezas:");
            foreach (var beer in beers)
            {
                Console.WriteLine(beer);
            }
        }

        public static void UseCalculator()
        {
            var calculator = new Calculator(15);
            Console.WriteLine($"Suma: {calculator.Add(15, 14)}");
            Console.WriteLine($"Resta: {calculator.Subs(15, 14)}");
            Console.WriteLine($"Factorial de 5: {calculator.Factorial(5)}");
            Console.WriteLine($"Raíz cuadrada de 25: {calculator.Sqr(25)}");
        }
        public static void BasicSwitchExample(char input)
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


        public static void AdvancedSwitchExample(int input)
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
