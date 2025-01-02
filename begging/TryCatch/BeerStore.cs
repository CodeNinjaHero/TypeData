using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Begging.Enums;
using Begging.Exceptions;
using Begging.ObjectPersonalizated;

namespace Begging.TryCatch
{
    internal class BeerStore
    {
        private List<Beer> beers = new List<Beer>();

        // Método para agregar cervezas a la lista, con manejo de excepciones
        public void AddBeer(string name, string description, BeerType type)
        {
            try
            {
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description))
                {
                    // Lanza la excepción personalizada EmptyNameOrDescriptionException
                    throw new EmptyNameOrDescriptionException("El nombre y la descripción de la cerveza no pueden estar vacíos.");
                }

                Beer newBeer = new Beer(name, description, type);
                beers.Add(newBeer);
                Console.WriteLine($"Cerveza añadida: {newBeer}");
            }
            catch (EmptyNameOrDescriptionException ex)
            {
                Console.WriteLine($"Error al agregar cerveza: {ex.Message}");
            }
        }

        // Método para mostrar cervezas, usando excepciones si la lista está vacía
        public void ShowBeers()
        {
            try
            {
                if (beers.Count == 0)
                {
                    // Lanza la excepción personalizada EmptyBeerListException
                    throw new EmptyBeerListException("No hay cervezas en la lista.");
                }

                foreach (var beer in beers)
                {
                    Console.WriteLine(beer.ToString());
                }
            }
            catch (EmptyBeerListException ex)
            {
                Console.WriteLine($"Error al mostrar cervezas: {ex.Message}");
            }
        }
    }
}
