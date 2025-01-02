using System;
using System.Collections.Generic;

namespace Begging.Dictionary
{
    internal class DictionaryManager
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();

        // Agregar un elemento
        public void Add(string key, string value)
        {
            dictionary[key] = value;
        }

        // Limpiar el diccionario
        public void Clear()
        {
            dictionary.Clear();
        }

        // Eliminar un elemento
        public void Remove(string key)
        {
            dictionary.Remove(key);
        }

        // Verificar si existe una clave
        public bool ContainsKey(string key)
        {
            return dictionary.ContainsKey(key);
        }

        // Verificar si existe un valor
        public bool ContainsValue(string value)
        {
            return dictionary.ContainsValue(value);
        }

        // Obtener un valor de forma segura
        public bool TryGetValue(string key, out string value)
        {
            return dictionary.TryGetValue(key, out value);
        }

        // Obtener todas las claves
        public ICollection<string> GetKeys()
        {
            return dictionary.Keys;
        }

        // Obtener todos los valores
        public ICollection<string> GetValues()
        {
            return dictionary.Values;
        }

        // Contar los elementos
        public int Count()
        {
            return dictionary.Count;
        }

        // Recorrer el diccionario
        public void PrintAll()
        {
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value}");
            }
        }
    }
}
