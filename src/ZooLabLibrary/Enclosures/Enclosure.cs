using ZooLabLibrary.Animals;
using ZooLabLibrary.Console;


namespace ZooLabLibrary.Enclosures
{
    public class Enclosure
    {
        public string Name { get; set; }

        public List<Animal> Animals { get; set; }

        public Zoo ParentZoo { get; set; }

        public int SquareFeet { get; set; }

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

        public void AddAnimal(Animal animal)
        {

            Animals.Add(animal);

            Console.WriteLine("New "+ animal.Type + " " + animal.Id+ " added to enclosure " + this.Name + " in zoo "+ ParentZoo.Location);
        }
    }

}
