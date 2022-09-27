using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Animals.Birds;
using ZooLabLibrary.Animals.Mammals;
using ZooLabLibrary.Animals.Reptiles;
using ZooLabLibrary.Animals;
using ZooLabLibrary.Enclosures;
using System.Xml.Linq;
using ZooLabLibrary.Exceptions;

namespace ZooLabLibrary.Test.Enclosures
{
    public class EnclosureTest
    {
        [Fact]
        public void ShouldBeAbleToCreateEnclosure()
        {
            Zoo zoo = new Zoo("New York");
            Enclosure enclosure = new Enclosure("test enclosure", zoo, 1000);
            Assert.NotNull(enclosure);
        }

        [Fact]
        public void ShouldBeAbleToCreateEnclosureWithEnimals()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Turtle(), new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 3000);
            Assert.NotNull(enclosure);
        }

        [Fact]
        public void ShouldBeAbleToAddAnimal()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 3000);
            enclosure.AddAnimals(new Turtle());
            List<string> enclosureAnimalTypes = new List<string>();
            foreach (var animal in enclosure.Animals)
            {
                enclosureAnimalTypes.Add(animal.GetType().Name);
            }
            Assert.Contains("Turtle", enclosureAnimalTypes);
        }

        [Fact]
        public void ShouldBeAbleToThrowExeptionWhenAddAnimalInEnclosureWithoutEnoughSpace()
        {
            Zoo zoo = new Zoo("New York");
            Enclosure enclosure = new Enclosure("test enclosure", zoo, 100);
            Assert.Throws<NoAvailableSpaceException>(() => enclosure.AddAnimals(new Elephant()));
        }

        [Fact]
        public void ShouldBeAbleToThrowExeptionWhenAddAnimalInEnclosureWithNotFriendlyAnimals()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Turtle(), new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 3000);
            Assert.Throws<NotFriendlyAnimalException>(() => enclosure.AddAnimals(new Lion()));
        }

        [Fact]
        public void ShouldBeAbleToThrowExeptionWhenAddAnimalInEnclosureWhereAnimalsNotFriendly()
        {
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Bison(), new Bison() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 3000);
            Assert.Throws<NotFriendlyAnimalException>(() => enclosure.AddAnimals(new Parrot()));
        }


    }
}
