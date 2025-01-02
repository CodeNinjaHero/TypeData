using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Begging.Dictionary;
using Begging.Enums;
using Begging.Inheritance;
using Begging.Loops;
using Begging.ObjectPersonalizated;
using Begging.SwitchExample;
using Begging.TryCatch;
namespace Begging
{
    public class Begging
    {
        public static void Main(string[] arr)
        {
            ShowBasicVariables();
            DemonstrateLoops();
            WorkWithListsAndObjects();
            UseCalculator();
            UseDictionary();
            UseTryCatch();
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
            var loops = new LoopsExample();
            loops.ExFor();
            loops.ExForEach();
            loops.ExWhile();
            loops.ExDoWhile();
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
                new Beer("Corona", "Desconocido", BeerType.Ale),
                new Beer("La mal portada", "Desconocido", BeerType.Ale),
                new Beer("Ron del caldas", "Desconocido", BeerType.Lager)
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
       public static void UseSwitch()
        {
            var witcher = new SwitchExample.Switch();
            witcher.BasicSwitchExample('a');
            witcher.AdvancedSwitchExample(12);
        }
        public static void UseDictionary()
        {

            DictionaryManager manager = new DictionaryManager();

            // Agregar elementos
            manager.Add("name", "John");
            manager.Add("age", "30");
            manager.Add("country", "USA");

            // Imprimir todos los elementos
            Console.WriteLine("Elementos del diccionario:");
            manager.PrintAll();

            // Verificar existencia de una clave
            Console.WriteLine("\n¿Contiene la clave 'age'?: " + manager.ContainsKey("age"));

            // Verificar existencia de un valor
            Console.WriteLine("¿Contiene el valor 'USA'?: " + manager.ContainsValue("USA"));

            // Obtener un valor de forma segura
            if (manager.TryGetValue("name", out string nameValue))
            {
                Console.WriteLine($"\nValor asociado a 'name': {nameValue}");
            }

            // Contar elementos
            Console.WriteLine("\nNúmero de elementos: " + manager.Count());

            // Eliminar un elemento
            manager.Remove("age");
            Console.WriteLine("\nDespués de eliminar 'age':");
            manager.PrintAll();

            // Limpiar el diccionario
            manager.Clear();
            Console.WriteLine("\nDespués de limpiar el diccionario:");
            manager.PrintAll();
        }

        public static void UseTryCatch()
        {
            BeerStore store = new BeerStore();

            // Intentamos agregar cervezas con datos válidos y inválidos
            store.AddBeer("Corona", "Cerveza ligera mexicana", BeerType.Lager);
            store.AddBeer("Guinness", "Cerveza oscura irlandesa", BeerType.Stout);
            store.AddBeer("", "Cerveza sin nombre", BeerType.Ale);  // Causa un error de validación
            store.AddBeer("Pale Ale", "", BeerType.Ale);  // Causa un error de validación

            // Intentamos mostrar las cervezas
            store.ShowBeers();

        }

    }

}
