using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Console;

namespace ZooLabLibrary.Exceptions
{
    public class NoAvailableSpaceException : Exception
    {
        public IConsole Console { get; set; } = new DefaultConsole();

        public NoAvailableSpaceException() { }

        public NoAvailableSpaceException(string message) : base(message) 
        {
            Console.WriteLine(message);
        }
    }
}
