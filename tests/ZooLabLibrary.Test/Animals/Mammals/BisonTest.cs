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
    public class BisonTest
    {
        [Fact]
        public void ShouldBeAbleToCreateBison()
        {
            Bison bison = new Bison();
            Assert.NotNull(bison);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickBison()
        {
            Bison bison = new Bison(iD: 0, isSick: true);
            Assert.NotNull(bison);
            Assert.True(bison.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickAndHungryBison()
        {
            Bison bison = new Bison(iD: 0, isSick: true, isHungry: true);
            Assert.NotNull(bison);
            Assert.True(bison.IsSick);
            Assert.True(bison.IsHungry);
        }

        [Fact]
        public void ShouldBeAbleToReturnRequiredSpaceSqFtForBison()
        {
            Bison bison = new Bison(0);
            var requiredSpaceSqFt = bison.RequiredSpaceSqFt;
            Assert.Equal(1000, requiredSpaceSqFt);
        }

        [Fact]
        public void ShouldBeAbleToReturnFavouriteFoodForBison()
        {
            Bison bison = new Bison(0);
            var favouriteFood = bison.FavouriteFood;
            Assert.Contains("Grass", favouriteFood);
        }

        [Fact]
        public void ShouldBeAbleToAssessIsAnimalFriendlyOrNotWithBison()
        {
            Bison bison1 = new Bison(0);
            Bison bison2 = new Bison(1);
            Lion lion = new Lion(2);
            Penguin penguin = new Penguin(3);
            Assert.False(bison1.IsFriendlyWith(lion));
            Assert.False(bison1.IsFriendlyWith(penguin));
            Assert.True(bison1.IsFriendlyWith(bison2));
        }


        [Fact]
        public void ShouldBeAbleToFeedBison()
        {
            Bison bison = new Bison(0);
            bison.IsHungry = true;
            Meat pieceOfMeat = new Meat();
            bison.Feed(pieceOfMeat);
            Assert.True(bison.IsHungry);
            Grass grass = new Grass();
            bison.Feed(grass);
            Assert.False(bison.IsHungry);
        }


        [Fact]
        public void ShouldBeAbleToAddSchedualeForBison()
        {
            Bison bison = new Bison(iD: 0, isSick: true);
            var hours = new List<int>() { 10, 15 };
            bison.AddScheduale(hours);
            Assert.Contains(10, bison.FeedScheduale);
            Assert.Contains(15, bison.FeedScheduale);
        }


        [Fact]
        public void ShouldBeAbleToHealBison()
        {
            Bison bison = new Bison(iD: 0, isSick: true);
            var antiDepression = new AntiDepression();
            bison.Heal(antiDepression);
            Assert.True(bison.IsSick);
            var antibiotics = new Antibiotics();
            bison.Heal(antibiotics);
            Assert.False(bison.IsSick);
        }
    }
}
