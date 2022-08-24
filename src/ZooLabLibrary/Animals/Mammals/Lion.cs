namespace ZooLabLibrary.Animals.Mammals
{
    public class Lion : Mammal
    {
        public Lion() { }
        public Lion(bool isSick) : base(isSick)
        {
            IsSick = isSick;
        }
    }
}
