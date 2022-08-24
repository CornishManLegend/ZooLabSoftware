namespace ZooLabLibrary.Animals.Birds
{
    public class Parrot : Bird
    {
        public Parrot() {}
        public Parrot(bool isSick) : base(isSick)
        {
            IsSick = isSick;

        }

    }
}
