using ZooLabLibrary.Animals;

namespace ZooLabLibrary.Employees;

public class Veterinarian : IEmployee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<Animal> AnimalExperiences { get; private set; } = new List<Animal>();

    public Veterinarian(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public Veterinarian(string firstName, string lastName, List<Animal> animalExperiences)
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
        if(this.AnimalExperiences.Contains(animal))
            return true;
        return false;
    }

    public bool HealAnimal(Animal animal)
    {
        if(animal.IsSick && this.HasAnimalExperience(animal))
        {
            animal.IsSick = false;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}