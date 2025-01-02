using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begging.Exceptions
{
    internal class EmptyNameOrDescriptionException :Exception
    {
        public EmptyNameOrDescriptionException(string message) : base(message) { }
    }
}
