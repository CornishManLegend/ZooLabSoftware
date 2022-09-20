using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Animals.Birds;
using ZooLabLibrary.Animals.Foods;
using ZooLabLibrary.Animals.Medicines;
using ZooLabLibrary.Animals.Reptiles;

namespace ZooLabLibrary.Test.Animals.Reptiles
{
    public class SnakeTest
    {
        [Fact]
        public void ShouldBeAbleToCreateSnake()
        {
            Snake snake = new Snake();
            Assert.NotNull(snake);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickSnake()
        {
            Snake snake = new Snake(iD: 0, isSick: true);
            Assert.NotNull(snake);
            Assert.True(snake.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateSickAndHungrySnake()
        {
            Snake snake = new Snake(iD: 0, isSick: true, isHungry: true);
            Assert.NotNull(snake);
            Assert.True(snake.IsSick);
            Assert.True(snake.IsHungry);
        }

        [Fact]
        public void ShouldBeAbleToReturnRequiredSpaceSqFt()
        {
            Snake snake = new Snake(0);
            var requiredSpaceSqFt = snake.RequiredSpaceSqFt;
            Assert.Equal(2, requiredSpaceSqFt);
        }

        [Fact]
        public void ShouldBeAbleToReturnFavouriteFood()
        {
            Snake snake = new Snake(0);
            var favouriteFood = snake.FavouriteFood;
            Assert.Contains("Meat", favouriteFood);
        }

        [Fact]
        public void ShouldBeAbleToAssessIsAnimalFriendlyOrNot()
        {
            Snake snake = new Snake(0);
            Penguin penguin = new Penguin(1);
            Assert.False(snake.IsFriendlyWith(penguin));
        }


        [Fact]
        public void ShouldBeAbleToFeedSnake()
        {
            Snake snake = new Snake(0);
            snake.IsHungry = true;
            Vegetable vegetable = new Vegetable();
            snake.Feed(vegetable);
            Assert.True(snake.IsHungry);
            Meat pieceOfMeat = new Meat();
            snake.Feed(pieceOfMeat);
            Assert.False(snake.IsHungry);

        }


        [Fact]
        public void ShouldBeAbleToAddScheduale()
        {
            Snake snake = new Snake(iD: 0, isSick: true);
            var hours = new List<int>() { 10, 15 };
            snake.AddScheduale(hours);
            Assert.Contains(10, snake.FeedScheduale);
            Assert.Contains(15, snake.FeedScheduale);
        }


        [Fact]
        public void ShouldBeAbleToHealSnake()
        {
            Snake snake = new Snake(iD: 0, isSick: true);
            var antiDepression = new AntiDepression();
            snake.Heal(antiDepression);
            Assert.True(snake.IsSick);
            var antibiotics = new Antibiotics();
            snake.Heal(antibiotics);
            Assert.False(snake.IsSick);
        }
    }
}
