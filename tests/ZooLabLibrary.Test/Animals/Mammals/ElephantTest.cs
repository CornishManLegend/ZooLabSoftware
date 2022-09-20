using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Animals.Birds;
using ZooLabLibrary.Animals.Foods;
using ZooLabLibrary.Animals.Mammals;
using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Test.Animals.Mammals
{
    public class ElephantTest
    {
        [Fact]
        public void ShouldBeAbleToCreateElephant()
        {
            Elephant elephant = new Elephant();
            Assert.NotNull(elephant);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickElephant()
        {
            Elephant elephant = new Elephant(iD: 0, isSick: true);
            Assert.NotNull(elephant);
            Assert.True(elephant.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickAndHungryElephant()
        {
            Elephant elephant = new Elephant(iD: 0, isSick: true, isHungry: true);
            Assert.NotNull(elephant);
            Assert.True(elephant.IsSick);
            Assert.True(elephant.IsHungry);
        }

        [Fact]
        public void ShouldBeAbleToReturnRequiredSpaceSqFtForElephant()
        {
            Elephant elephant = new Elephant(0);
            var requiredSpaceSqFt = elephant.RequiredSpaceSqFt;
            Assert.Equal(1000, requiredSpaceSqFt);
        }

        [Fact]
        public void ShouldBeAbleToReturnFavouriteFoodForElephant()
        {
            Elephant elephant = new Elephant(0);
            var favouriteFood = elephant.FavouriteFood;
            Assert.Contains("Grass", favouriteFood);
            Assert.Contains("Vegetable", favouriteFood);
        }

        [Fact]
        public void ShouldBeAbleToAssessIsAnimalFriendlyOrNotWithElephant()
        {
            Elephant elephant1 = new Elephant(0);
            Elephant elephant2 = new Elephant(1);
            Lion lion = new Lion(2);
            Penguin penguin = new Penguin(3);
            Parrot parrot = new Parrot(4);
            Assert.False(elephant1.IsFriendlyWith(lion));
            Assert.False(elephant1.IsFriendlyWith(penguin));
            Assert.True(elephant1.IsFriendlyWith(elephant2));
            Assert.True(elephant1.IsFriendlyWith(parrot));
        }


        [Fact]
        public void ShouldBeAbleToFeedElephant()
        {
            Elephant elephant = new Elephant(0);
            elephant.IsHungry = true;
            Meat pieceOfMeat = new Meat();
            elephant.Feed(pieceOfMeat);
            Assert.True(elephant.IsHungry);
            Grass grass = new Grass();
            elephant.Feed(grass);
            Assert.False(elephant.IsHungry);
            elephant.IsHungry = true;
            Vegetable vegetable = new Vegetable();
            elephant.Feed(vegetable);
            Assert.False(elephant.IsHungry);

        }


        [Fact]
        public void ShouldBeAbleToAddSchedualeForElephant()
        {
            Elephant elephant = new Elephant(iD: 0, isSick: true);
            var hours = new List<int>() { 10, 15 };
            elephant.AddScheduale(hours);
            Assert.Contains(10, elephant.FeedScheduale);
            Assert.Contains(15, elephant.FeedScheduale);
        }


        [Fact]
        public void ShouldBeAbleToHealElephant()
        {
            Elephant elephant = new Elephant(iD: 0, isSick: true);
            var antiDepression = new AntiDepression();
            elephant.Heal(antiDepression);
            Assert.True(elephant.IsSick);
            var antibiotics = new Antibiotics();
            elephant.Heal(antibiotics);
            Assert.False(elephant.IsSick);
        }
    }
}
