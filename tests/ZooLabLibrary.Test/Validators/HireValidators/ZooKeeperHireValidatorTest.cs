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

namespace ZooLabLibrary.Test.Validators.HireValidators
{
    public class ZooKeeperHireValidatorTest
    {
        [Fact]
        public void ShouldBeAbleToCreateZooKeeperHireValidator()
        {
            ZooKeeperHireValidator zooKeeperHireValidator = new ZooKeeperHireValidator(new Zoo("New York"));
            Assert.NotNull(zooKeeperHireValidator);
        }

        [Fact]
        public void ShouldBeAbleToValidateZooKeeperWhoHasExperiences()
        {
            List<Animal> animalExperiences = new List<Animal>() { new Parrot(), new Turtle(), new Elephant() };
            ZooKeeper zooKeeper = new ZooKeeper("John", "Wayne", animalExperiences);
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Turtle(), new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 3000);
            zoo.AddEnclosure(enclosure);
            ZooKeeperHireValidator zooKeeperHireValidator = new ZooKeeperHireValidator(zoo);
            Assert.Empty(zooKeeperHireValidator.ValidateEmployee(zooKeeper));
        }

        [Fact]
        public void ShouldBeAbleToValidateZooKeeperWhoHasNotExperiences()
        {
            List<Animal> animalExperiences = new List<Animal>() { new Parrot(), new Turtle(), new Elephant() };
            ZooKeeper zooKeeper = new ZooKeeper("John", "Wayne", animalExperiences);
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Bison(), new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 3000);
            zoo.AddEnclosure(enclosure);
            ZooKeeperHireValidator zooKeeperHireValidator = new ZooKeeperHireValidator(zoo);
            Assert.NotEmpty(zooKeeperHireValidator.ValidateEmployee(zooKeeper));
        }
    }
}
