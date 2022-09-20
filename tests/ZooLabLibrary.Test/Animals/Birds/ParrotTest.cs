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
    public class ParrotTest
    {
        [Fact]
        public void ShouldBeAbleToCreateParrot()
        {
            Parrot parrot = new Parrot();
            Assert.NotNull(parrot);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickParrot()
        {
            Parrot parrot = new Parrot(iD: 0, isSick: true);
            Assert.NotNull(parrot);
            Assert.True(parrot.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickAndHungryParrot()
        {
            Parrot parrot = new Parrot(iD: 0, isSick: true, isHungry: true);
            Assert.NotNull(parrot);
            Assert.True(parrot.IsSick);
            Assert.True(parrot.IsHungry);
        }

        [Fact]
        public void ShouldBeAbleToReturnRequiredSpaceSqFtForParrot()
        {
            Parrot parrot = new Parrot(0);
            var requiredSpaceSqFt = parrot.RequiredSpaceSqFt;
            Assert.Equal(5, requiredSpaceSqFt);
        }

        [Fact]
        public void ShouldBeAbleToReturnFavouriteFoodForParrot()
        {
            Parrot parrot = new Parrot(0);
            var favouriteFood = parrot.FavouriteFood;
            Assert.Contains("Vegetable", favouriteFood);
        }

        [Fact]
        public void ShouldBeAbleToAssessIsAnimalFriendlyOrNotWithParrot()
        {
            Parrot parrot = new Parrot(0);
            Penguin penguin = new Penguin(1);
            Assert.False(parrot.IsFriendlyWith(penguin));
        }


        [Fact]
        public void ShouldBeAbleToFeedParrot()
        {
            Parrot parrot = new Parrot(0);
            parrot.IsHungry = true;
            Meat pieceOfMeat = new Meat();
            parrot.Feed(pieceOfMeat);
            Assert.True(parrot.IsHungry);
            Vegetable vegetable = new Vegetable();
            parrot.Feed(vegetable);
            Assert.False(parrot.IsHungry);
        }


        [Fact]
        public void ShouldBeAbleToAddSchedualeForParrot()
        {
            Parrot parrot = new Parrot(iD: 0, isSick: true);
            var hours = new List<int>() { 10, 15 };
            parrot.AddScheduale(hours);
            Assert.Contains(10, parrot.FeedScheduale);
            Assert.Contains(15, parrot.FeedScheduale);
        }


        [Fact]
        public void ShouldBeAbleToHealParrot()
        {
            Parrot parrot = new Parrot(iD: 0, isSick: true);
            var antiDepression = new AntiDepression();
            parrot.Heal(antiDepression);
            Assert.False(parrot.IsSick);
        }


    }
}
