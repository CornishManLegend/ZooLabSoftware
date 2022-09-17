
using ZooLabLibrary.Employees;

namespace ZooLab.Animals
{
    public class FeedTime
    {
        public DateTime Time { get; }

        public ZooKeeper? FeedBy { get; set; }

        public FeedTime(DateTime feedTime)
        {
            Time = feedTime;
        }

        public ZooKeeper FeedByZooKeeper(ZooKeeper zooKeeper)
        {
            return FeedBy = zooKeeper;
        }
    }
}
