using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLabLibrary.Exceptions
{
    public class NoAvailableEnclosureException : Exception
    {
        public NoAvailableEnclosureException() { }

        public NoAvailableEnclosureException(string message)
            : base(message) { }
    }
}
