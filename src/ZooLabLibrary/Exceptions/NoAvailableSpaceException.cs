using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLabLibrary.Exceptions
{
    public class NoAvailableSpaceException : Exception
    {
        public NoAvailableSpaceException() { }

        public NoAvailableSpaceException(string message)
            : base(message) { }
    }
}
