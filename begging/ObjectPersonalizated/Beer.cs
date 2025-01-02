using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Begging.Enums;

namespace Begging.ObjectPersonalizated
{
    internal class Beer
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public BeerType Type { get; set; }  

        public Beer(string name, string description, BeerType type)
        {
            Name = name;
            Description = description;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Name} - {Description} ({Type})";
        }
    }
}
/*
private: Solo accesible dentro de la misma clase.
protected: Accesible dentro de la misma clase y las clases derivadas.
internal: Accesible dentro del mismo ensamblado (proyecto/solución).
public: Accesible desde cualquier lugar.
*/