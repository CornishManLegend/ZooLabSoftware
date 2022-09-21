using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Console;
using ZooLabLibrary.Employees;

namespace ZooLabLibrary.Exceptions
{
    public class NoNeededExperienceException : Exception
    {
        public IConsole Console { get; set; } = new DefaultConsole();

        public NoNeededExperienceException() { }

        public NoNeededExperienceException(string message): base(message) 
        {
            Console.WriteLine(message);
        }
    }
}