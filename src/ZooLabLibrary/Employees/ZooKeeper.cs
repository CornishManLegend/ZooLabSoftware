using ZooLabLibrary.Animals;


namespace ZooLabLibrary.Employees;

public class ZooKeeper : IEmployee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

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
    }

    public bool HasAnimalExperience(Animal animal)
    {
        if (this.AnimalExperiences.Contains(animal))
            return true;
        return false;
    }

    public bool FeedAnimal(Animal animal)
    {
        if (animal.IsHungry && this.HasAnimalExperience(animal))
        {
            animal.IsHungry = false;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}