using System;
using ZooLabLibrary.Console;

namespace ZooLabLibrary
{
    public class ZooApp
    {
        private List<Zoo> zoos = new List<Zoo>();

        public IConsole Console { get; set; } = new DefaultConsole();

        public void AddZoo(Zoo zoo)
        {
            zoos.Add(zoo);

            Console.WriteLine("New zoo located in " + zoo.Location + " added to Zoo Corporation");
        }

        public List<Zoo> GetZoos()
        {
            return zoos;
        }
    }
}