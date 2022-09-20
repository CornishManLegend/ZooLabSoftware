using ZooLabLibrary.Animals;
using ZooLabLibrary.Console;


namespace ZooLabLibrary.Enclosures
{
    public class Enclosure
    {
        public string Name { get; private set; }

        public List<Animal> Animals { get; private set; }

        public Zoo ParentZoo { get; private set; }

        public int SquareFeet { get; private set; }

        public IConsole Console { get; set; } = new DefaultConsole();

        public Enclosure(string name, List<Animal> animals, Zoo parentZoo, int squareFeet)
        {
            Name = name;
            Animals = animals;
            ParentZoo = parentZoo;
            SquareFeet = squareFeet;
        }

        public Enclosure(string name, Zoo parentZoo, int squareFeet)
        {
            Name = name;
            Animals = new List<Animal>();
            ParentZoo = parentZoo;
            SquareFeet = squareFeet;
        }

        public void AddAnimals(Animal animal)
        {
            Animals.Add(animal);
            Console.WriteLine("New " + animal.GetType().Name + " " + animal.ID + " added to enclosure " + this.Name + " in zoo " + ParentZoo.Location);
        }
    }

}
