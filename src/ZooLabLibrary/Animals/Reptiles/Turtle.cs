namespace ZooLabLibrary.Animals.Reptiles
{
    public class Turtle : Reptile
    {
        public Turtle() { }
        public Turtle(bool isSick) : base(isSick)
        {
            IsSick = isSick;
        }
    }
}
