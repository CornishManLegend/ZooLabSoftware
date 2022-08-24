
namespace ZooLabLibrary.Animals.Birds
{
    public class Penguin : Bird
    {
        public Penguin() { }
        public Penguin(bool isSick) : base(isSick)
        {
            IsSick = isSick;
        }
    }
}
