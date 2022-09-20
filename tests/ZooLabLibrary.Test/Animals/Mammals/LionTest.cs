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
    public class LionTest
    {
        [Fact]
        public void ShouldBeAbleToCreateLion()
        {
            Lion lion = new Lion();
            Assert.NotNull(lion);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickLion()
        {
            Lion lion = new Lion(iD: 0, isSick: true);
            Assert.NotNull(lion);
            Assert.True(lion.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickAndHungryLion()
        {
            Lion lion = new Lion(iD: 0, isSick: true, isHungry: true);
            Assert.NotNull(lion);
            Assert.True(lion.IsSick);
            Assert.True(lion.IsHungry);
        }

        [Fact]
        public void ShouldBeAbleToReturnRequiredSpaceSqFtForLion()
        {
            Lion lion = new Lion(0);
            var requiredSpaceSqFt = lion.RequiredSpaceSqFt;
            Assert.Equal(1000, requiredSpaceSqFt);
        }

        [Fact]
        public void ShouldBeAbleToReturnFavouriteFoodForLion()
        {
            Lion lion = new Lion(0);
            var favouriteFood = lion.FavouriteFood;
            Assert.Contains("Meat", favouriteFood);
        }

        [Fact]
        public void ShouldBeAbleToAssessIsAnimalFriendlyOrNotWithLion()
        {
            Lion lion = new Lion(0);
            Penguin penguin = new Penguin(1);
            Assert.False(lion.IsFriendlyWith(penguin));
        }


        [Fact]
        public void ShouldBeAbleToFeedLion()
        {
            Lion lion = new Lion(0);
            lion.IsHungry = true;
            Vegetable vegetable = new Vegetable();
            lion.Feed(vegetable);
            Assert.True(lion.IsHungry);
            Meat pieceOfMeat = new Meat();
            lion.Feed(pieceOfMeat);
            Assert.False(lion.IsHungry);
        }


        [Fact]
        public void ShouldBeAbleToAddSchedualeForLion()
        {
            Lion lion = new Lion(iD: 0, isSick: true);
            var hours = new List<int>() { 10, 15 };
            lion.AddScheduale(hours);
            Assert.Contains(10, lion.FeedScheduale);
            Assert.Contains(15, lion.FeedScheduale);
        }


        [Fact]
        public void ShouldBeAbleToHealLion()
        {
            Lion lion = new Lion(iD: 0, isSick: true);
            var antiDepression = new AntiDepression();
            lion.Heal(antiDepression);
            Assert.True(lion.IsSick);
            var antibiotics = new Antibiotics();
            lion.Heal(antibiotics);
            Assert.False(lion.IsSick);
        }
    }
}
