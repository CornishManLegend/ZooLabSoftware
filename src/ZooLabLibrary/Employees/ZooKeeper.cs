using ZooLab.Animals;
using ZooLabLibrary.Animals;
using ZooLabLibrary.Console;


namespace ZooLabLibrary.Employees;

public class ZooKeeper : IEmployee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public IConsole Console { get; set; } = new DefaultConsole();

    public List<Animal> AnimalExperiences { get; private set; } = new List<Animal>();

    public ZooKeeper(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public ZooKeeper(string firstName, string lastName, List<Animal> animalExperiences)
    {
        FirstName = firstName;
        LastName = lastName;
        AnimalExperiences = animalExperiences;
    }

    public void AddAnimalExperience(Animal animal)
    {
        AnimalExperiences.Add(animal);
        Console.WriteLine("ZooKeeper " + this.ToString() + " got a new experience with a " + animal.GetType().Name);
    }

    public bool HasAnimalExperience(Animal animal)
    {
        var animalNames = new List<string>();
        foreach (Animal ani in this.AnimalExperiences)
        {
            animalNames.Add(ani.GetType().Name);
        }
        if (animalNames.Contains(animal.GetType().Name))
            return true;
        return false;
    }

    public bool FeedAnimal(Animal animal)
    {
        if (animal.IsHungry && this.HasAnimalExperience(animal))
        {
            animal.IsHungry = false;
            animal.FeedTimes.Add(new FeedTime(DateTime.Now, this));
            //Console.WriteLine("The" + animal.GetType().Name + " " + animal.ID
            //    + " was fed by zooKeeper " + this.ToString());
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}