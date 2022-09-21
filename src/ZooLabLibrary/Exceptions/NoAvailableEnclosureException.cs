using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Console;

namespace ZooLabLibrary.Exceptions
{
    public class NoAvailableEnclosureException : Exception
    {
        public IConsole Console { get; set; } = new DefaultConsole();
        public NoAvailableEnclosureException() { }

        public NoAvailableEnclosureException(string message) : base(message) 
        {
            Console.WriteLine(message);
        }
    }
}
