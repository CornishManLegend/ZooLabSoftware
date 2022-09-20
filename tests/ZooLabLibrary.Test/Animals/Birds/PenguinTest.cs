using ZooLabLibrary.Animals.Birds;
using ZooLabLibrary.Animals.Medicines;
using ZooLabLibrary.Animals.Foods;
using ZooLabLibrary.Enclosures;
using ZooLabLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Animals;
using Xunit;


namespace ZooLabLibrary.Test.Animals.Birds
{
    public class PenguinTest
    {
        [Fact]
        public void ShouldBeAbleToCreatePenguin()
        {
            Penguin penguin = new Penguin();
            Assert.NotNull(penguin);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickPenguin()
        {
            Penguin penguin = new Penguin(iD: 0, isSick: true);
            Assert.NotNull(penguin);
            Assert.True(penguin.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickAndHungryPenguin()
        {
            Penguin penguin = new Penguin(iD: 0, isSick: true, isHungry: true);
            Assert.NotNull(penguin);
            Assert.True(penguin.IsSick);
            Assert.True(penguin.IsHungry);
        }

        [Fact]
        public void ShouldBeAbleToReturnRequiredSpaceSqFtForPenguin()
        {
            Penguin penguin = new Penguin(0);
            var requiredSpaceSqFt = penguin.RequiredSpaceSqFt;
            Assert.Equal(10, requiredSpaceSqFt);
        }

        [Fact]
        public void ShouldBeAbleToReturnFavouriteFoodForPenguin()
        {
            Penguin penguin = new Penguin(0);
            var favouriteFood = penguin.FavouriteFood;
            Assert.Contains("Vegetable", favouriteFood);
            Assert.Contains("Grass", favouriteFood);
        }

        [Fact]
        public void ShouldBeAbleToAssessIsAnimalFriendlyOrNotWithPenguin()
        {

            Penguin penguin = new Penguin(0);
            Parrot parrot = new Parrot(1);
            Assert.False(penguin.IsFriendlyWith(parrot));
        }


        [Fact]
        public void ShouldBeAbleToFeedPenguin()
        {
            Penguin penguin = new Penguin(0);
            penguin.IsHungry = true;
            Meat pieceOfMeat = new Meat();
            penguin.Feed(pieceOfMeat);
            Assert.True(penguin.IsHungry);
            Vegetable vegetable = new Vegetable();
            penguin.Feed(vegetable);
            Assert.False(penguin.IsHungry);
        }


        [Fact]
        public void ShouldBeAbleToAddSchedualeForPenguin()
        {
            Penguin penguin = new Penguin(0);
            var hours = new List<int>() { 10, 15 };
            penguin.AddScheduale(hours);
            Assert.Contains(10, penguin.FeedScheduale);
            Assert.Contains(15, penguin.FeedScheduale);
        }


        [Fact]
        public void ShouldBeAbleToHealPenguin()
        {
            Penguin penguin = new Penguin(iD: 0, isSick: true);
            var antiInflammatory = new AntiInflammatory();
            penguin.Heal(antiInflammatory);
            Assert.False(penguin.IsSick);
        }


    }
}
