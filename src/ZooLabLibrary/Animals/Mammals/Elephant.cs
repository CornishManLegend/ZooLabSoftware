namespace ZooLabLibrary.Animals.Mammals
{
    public class Elephant : Mammal
    {
        public Elephant() { }
        public Elephant(bool isSick) : base(isSick)
        {
            IsSick = isSick;
        }
    }
}
