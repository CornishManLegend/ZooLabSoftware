using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Animals.Birds;
using ZooLabLibrary.Animals.Foods;
using ZooLabLibrary.Animals.Mammals;
using ZooLabLibrary.Animals.Medicines;
using ZooLabLibrary.Animals.Reptiles;

namespace ZooLabLibrary.Test.Animals.Reptiles
{
    public class TurtleTest
    {
        [Fact]
        public void ShouldBeAbleToCreateTurtle()
        {
            Turtle turtle = new Turtle();
            Assert.NotNull(turtle);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickTurtle()
        {
            Turtle turtle = new Turtle(iD: 0, isSick: true);
            Assert.NotNull(turtle);
            Assert.True(turtle.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickAndHungryTurtle()
        {
            Turtle turtle = new Turtle(iD: 0, isSick: true, isHungry: true);
            Assert.NotNull(turtle);
            Assert.True(turtle.IsSick);
            Assert.True(turtle.IsHungry);
        }

        [Fact]
        public void ShouldBeAbleToReturnRequiredSpaceSqFtForTurtle()
        {
            Turtle turtle = new Turtle(0);
            var requiredSpaceSqFt = turtle.RequiredSpaceSqFt;
            Assert.Equal(5, requiredSpaceSqFt);
        }

        [Fact]
        public void ShouldBeAbleToReturnFavouriteFoodForTurtle()
        {
            Turtle turtle = new Turtle(0);
            var favouriteFood = turtle.FavouriteFood;
            Assert.Contains("Vegetable", favouriteFood);
        }

        [Fact]
        public void ShouldBeAbleToAssessIsAnimalFriendlyOrNotWithTurtle()
        {
            Turtle turtle = new Turtle(0);
            Penguin penguin = new Penguin(1);
            Elephant elephant = new Elephant(2);
            Assert.False(turtle.IsFriendlyWith(penguin));
            Assert.True(turtle.IsFriendlyWith(elephant));
        }


        [Fact]
        public void ShouldBeAbleToFeedTurtle()
        {
            Turtle turtle = new Turtle(0);
            turtle.IsHungry = true;
            Meat pieceOfMeat = new Meat();
            turtle.Feed(pieceOfMeat);
            Assert.True(turtle.IsHungry);
            Vegetable vegetable = new Vegetable();
            turtle.Feed(vegetable);
            Assert.False(turtle.IsHungry);
        }


        [Fact]
        public void ShouldBeAbleToAddSchedualeForTurtle()
        {
            Turtle turtle = new Turtle(iD: 0, isSick: true);
            var hours = new List<int>() { 10, 15 };
            turtle.AddScheduale(hours);
            Assert.Contains(10, turtle.FeedScheduale);
            Assert.Contains(15, turtle.FeedScheduale);
        }


        [Fact]
        public void ShouldBeAbleToHealTurtle()
        {
            Turtle turtle = new Turtle(iD: 0, isSick: true);
            var antiDepression = new AntiDepression();
            turtle.Heal(antiDepression);
            Assert.True(turtle.IsSick);
            var antibiotics = new Antibiotics();
            turtle.Heal(antibiotics);
            Assert.False(turtle.IsSick);
        }
    }
}
