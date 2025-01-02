using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begging.Exceptions
{
    internal class EmptyBeerListException : Exception
    {
        public EmptyBeerListException(string message) : base(message) { }
    }
}
