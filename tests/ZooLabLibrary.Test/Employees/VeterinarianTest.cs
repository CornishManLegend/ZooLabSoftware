using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Animals;
using ZooLabLibrary.Animals.Birds;
using ZooLabLibrary.Employees;

namespace ZooLabLibrary.Test.Employees
{
    public class VeterinarianTest
    {
        [Fact]
        public void ShouldBeAbleToCreateVeterinarian()
        {
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Wayne");
            Assert.NotNull(veterinarian);
        }

        [Fact]
        public void ShouldBeAbleToCreateVeterinarianWithExperiences()
        {
            var experiences = new List<Animal>() { new Parrot(0), new Penguin(1) };

            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Silver", animalExperiences: experiences);
            Assert.NotNull(veterinarian);
        }
        

        [Fact]
        public void ShouldBeAbleToAddAnimalExperience()
        {
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Silver");
            veterinarian.AddAnimalExperience(new Parrot());
            var animalNames = new List<string>();
            foreach (Animal animal in veterinarian.AnimalExperiences)
            {
                animalNames.Add(animal.GetType().Name);
            }
            Assert.Contains("Parrot", animalNames);
        }


        [Fact]
        public void ShouldBeAbleToReturnAnimalExperience()
        {
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Silver");
            veterinarian.AddAnimalExperience(new Parrot());
            var parrot = new Parrot(1);
            var penguin = new Penguin(2);
            Assert.True(veterinarian.HasAnimalExperience(parrot));
            Assert.False(veterinarian.HasAnimalExperience(penguin));
        }


        [Fact]
        public void ShouldBeAbleToHealAnimal()
        {
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Silver");
            veterinarian.AddAnimalExperience(new Parrot(0));
            var parrot = new Parrot(iD: 1, isSick: true);
            var penguin = new Penguin(iD: 2, isSick: true);
            Assert.True(veterinarian.HealAnimal(parrot));
            Assert.False(parrot.IsSick);
            Assert.False(veterinarian.HealAnimal(penguin));
            Assert.True(penguin.IsSick);
        }


        [Fact]
        public void ShouldBeAbleToReturnVeterinarianFullName()
        {
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Silver");
            var veterinarianFullName = veterinarian.ToString();
            Assert.Equal(0, string.Compare("John Silver", veterinarianFullName));
        }

    }
}
