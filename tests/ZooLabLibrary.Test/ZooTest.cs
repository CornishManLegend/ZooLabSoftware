using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Animals.Birds;
using ZooLabLibrary.Animals.Mammals;
using ZooLabLibrary.Animals.Reptiles;
using ZooLabLibrary.Animals;
using ZooLabLibrary.Employees;
using ZooLabLibrary.Enclosures;
using ZooLabLibrary.Validators.HireValidators;
using ZooLabLibrary.Exceptions;

namespace ZooLabLibrary.Test
{
    public class ZooTest
    {
        [Fact]
        public void ShouldBeAbleToCreateZoo()
        {
            Zoo zoo = new Zoo("New York");
            Assert.NotNull(zoo);
        }

        [Fact]
        public void ShouldBeAbleToAddEnclosure()
        {
            Zoo zoo = new Zoo("New York");
            Assert.Empty(zoo.Enclosures);
            List<Animal> animalsList = new List<Animal>() { new Turtle(), new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 3000);
            zoo.AddEnclosure(enclosure);
            Assert.NotEmpty(zoo.Enclosures);
        }

        [Fact]
        public void ShouldBeAbleToFindAvailableEnclosure()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 2000);
            zoo.AddEnclosure(enclosure);
            var availableEnclosure = zoo.FindAvailableEnclosure(new Turtle());
            Assert.Equal(enclosure.Name, availableEnclosure.Name);
        }

        [Fact]
        public void ShouldBeAbleToThrowExeptionWhenNotFindAvailableEnclosure()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 1005);
            zoo.AddEnclosure(enclosure);
            Turtle turtle = new Turtle();
            var ex = Assert.Throws<NoAvailableEnclosureException>(() => zoo.FindAvailableEnclosure(turtle));
            Assert.Equal("There is no available enclosure in the zoo " 
                + zoo.Location + " for the animal " + turtle.GetType().Name + " " + turtle.ID, ex.Message);

            
        }

        [Fact]
        public void ShouldBeAbleToThrowExeptionWhenNotFindAvailableEnclosureBecauseOfUnfriendliness()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 3005);
            zoo.AddEnclosure(enclosure);
            Lion lion = new Lion();
            var ex = Assert.Throws<NoAvailableEnclosureException>(() => zoo.FindAvailableEnclosure(lion));
            Assert.Equal("There is no available enclosure in the zoo "
                + zoo.Location + " for the animal " + lion.GetType().Name + " " + lion.ID, ex.Message);
        }

        [Fact]
        public void ShouldBeAbleToHireZookeeper()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 1005);
            zoo.AddEnclosure(enclosure);
            var experiences = new List<Animal>() { new Parrot(), new Elephant() };
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Silver", animalExperiences: experiences);
            zoo.HireEmployee(zooKeeper);
            Assert.Contains(zooKeeper, zoo.Employees);
        }


        [Fact]
        public void ShouldBeAbleToThrowNoNeededExperienceExceptionWhenHireZookeeper()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 1005);
            zoo.AddEnclosure(enclosure);
            var experiences = new List<Animal>() { new Elephant() };
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Silver", animalExperiences: experiences);
            var ex = Assert.Throws<NoNeededExperienceException>(() => zoo.HireEmployee(zooKeeper));
            Assert.Equal("The employee " + zooKeeper.FirstName + " " + zooKeeper.LastName 
                + " is not needed due to lack of experience", ex.Message);
        }

        [Fact]
        public void ShouldBeAbleToHireVeterinarian()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 1005);
            zoo.AddEnclosure(enclosure);
            var experiences = new List<Animal>() { new Parrot(), new Elephant() };
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Silver", animalExperiences: experiences);
            zoo.HireEmployee(veterinarian);
            Assert.Contains(veterinarian, zoo.Employees);
        }

        [Fact]
        public void ShouldBeAbleToThrowNoNeededExperienceExceptionWhenHireVeterinarian()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 1005);
            zoo.AddEnclosure(enclosure);
            var experiences = new List<Animal>() { new Elephant() };
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Silver", animalExperiences: experiences);
            var ex = Assert.Throws<NoNeededExperienceException>(() => zoo.HireEmployee(veterinarian));
            Assert.Equal("The employee " + veterinarian.FirstName + " " + veterinarian.LastName
                + " is not needed due to lack of experience", ex.Message);
        }

        [Fact]
        public void ShouldBeAbleToFeedAnimals()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() 
            { 
                new Parrot(iD: 1, isSick: false, isHungry: true), 
                new Elephant(iD: 2, isSick: false, isHungry: true) 
            };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 1005);
            zoo.AddEnclosure(enclosure);
            var experiences = new List<Animal>() { new Parrot(), new Elephant() };
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Silver", animalExperiences: experiences);
            zoo.HireEmployee(zooKeeper);
            zoo.FeedAnimals();
            foreach(Animal animal in animalsList)
            {
                Assert.False(animal.IsHungry);
            }
        }

        [Fact]
        public void ShouldBeAbleToHealAnimals()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>()
            {
                new Parrot(iD: 1, isSick: true, isHungry: false),
                new Elephant(iD: 2, isSick: true, isHungry: false)
            };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 1005);
            zoo.AddEnclosure(enclosure);
            var experiences = new List<Animal>() { new Parrot(), new Elephant() };
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Silver", animalExperiences: experiences);
            zoo.HireEmployee(veterinarian);
            zoo.HealAnimals();
            foreach (Animal animal in animalsList)
            {
                Assert.False(animal.IsSick);
            }
        }
    }
}
