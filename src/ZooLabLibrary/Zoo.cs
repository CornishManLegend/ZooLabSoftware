using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Animals;
using ZooLabLibrary.Console;
using ZooLabLibrary.Employees;
using ZooLabLibrary.Enclosures;

namespace ZooLabLibrary
{
    public class Zoo
    {

        public IConsole Console { get; set; } = new DefaultConsole();

        public List<Enclosure> Enclosures { get; set; }
        public List<IEmployee> Employees { get; set; }
        public string Location { get; set; }

        public Zoo(string location)
        {
            Location = location;
            Enclosures = new List<Enclosure>();
            Employees = new List<IEmployee>();
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            Enclosures.Add(enclosure);

            Console.WriteLine("New Enclosure added: " + enclosure.Name);
        }

    }
}
