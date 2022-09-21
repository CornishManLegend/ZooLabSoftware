using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLab.Animals;
using ZooLabLibrary.Employees;

namespace ZooLabLibrary.Test.Animals
{
    public class FeedTimeTest
    {
        [Fact]
        public void ShouldBeAbleToCreateFeedTime()
        {
            FeedTime feedTime = new FeedTime(feedTime: DateTime.Now, new ZooKeeper("FirstName", "LastName"));
            Assert.NotNull(feedTime);
        }

        [Fact]
        public void ShouldBeAbleToGetTime()
        {
            DateTime dateTime = new DateTime(2022, 9, 20);
            FeedTime feedTime = new FeedTime(dateTime, new ZooKeeper("FirstName", "LastName"));
            Assert.Equal(dateTime, feedTime.Time);
        }

        [Fact]
        public void ShouldBeAbleToReturnFeedBy()
        {
            FeedTime feedTime = new FeedTime(feedTime: DateTime.Now, new ZooKeeper("FirstName", "LastName"));
            ZooKeeper zooKeeper = new ZooKeeper("John", "Silver");
            Assert.Equal(feedTime.FeedByZooKeeper(zooKeeper), feedTime.FeedBy);
        }

    }
}
