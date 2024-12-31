using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begging
{
    internal class Beer
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Beer(string name, string description) 
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name} - {Description}";
        }
    }
}
/*
private: Solo accesible dentro de la misma clase.
protected: Accesible dentro de la misma clase y las clases derivadas.
internal: Accesible dentro del mismo ensamblado (proyecto/solución).
public: Accesible desde cualquier lugar.
*/