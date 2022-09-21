using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Animals.Birds;
using ZooLabLibrary.Animals;
using ZooLabLibrary.Employees;

namespace ZooLabLibrary.Test.Employees
{
    public class ZooKeeperTest
    {
        [Fact]
        public void ShouldBeAbleToCreateZooKeeper()
        {
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Wayne");
            Assert.NotNull(zooKeeper);
        }

        [Fact]
        public void ShouldBeAbleToCreateZooKeeperWithExperiences()
        {
            var experiences = new List<Animal>() { new Parrot(0), new Penguin(1) };
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Silver", animalExperiences: experiences);
            Assert.NotNull(zooKeeper);
        }

        [Fact]
        public void ShouldBeAbleToAddAnimalExperience()
        {
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Silver");
            zooKeeper.AddAnimalExperience(new Parrot());
            var animalNames = new List<string>();
            foreach (Animal animal in zooKeeper.AnimalExperiences)
            {
                animalNames.Add(animal.GetType().Name);
            }
            Assert.Contains("Parrot", animalNames);
        }


        [Fact]
        public void ShouldBeAbleToReturnAnimalExperience()
        {
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Silver");
            zooKeeper.AddAnimalExperience(new Parrot());
            var parrot = new Parrot(1);
            var penguin = new Penguin(2);
            Assert.True(zooKeeper.HasAnimalExperience(parrot));
            Assert.False(zooKeeper.HasAnimalExperience(penguin));
        }

        [Fact]
        public void ShouldBeAbleToFeedAnimal()
        {
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Silver");
            zooKeeper.AddAnimalExperience(new Parrot());
            var parrot = new Parrot(1);
            parrot.IsHungry = true;
            var penguin = new Penguin(2);
            penguin.IsHungry = true;
            Assert.True(zooKeeper.FeedAnimal(parrot));
            Assert.Equal(zooKeeper, parrot.FeedTimes[0].FeedBy);
            Assert.False(parrot.IsHungry);
            Assert.False(zooKeeper.FeedAnimal(penguin));
            Assert.True(penguin.IsHungry);
        }


        [Fact]
        public void ShouldBeAbleToReturnVeterinarianFullName()
        {
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Silver");
            var zooKeeperFullName = zooKeeper.ToString();
            Assert.Equal(0, string.Compare("John Silver", zooKeeperFullName));
        }
    }
}
