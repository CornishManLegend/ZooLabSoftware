using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Console;

namespace ZooLab.Test
{
    public class MockConsole : IConsole
    {
        public List<string> Output { get; } = new List<string>();

        public void WriteLine(string message)
        {
            Output.Add(message);
        }
    }
}
