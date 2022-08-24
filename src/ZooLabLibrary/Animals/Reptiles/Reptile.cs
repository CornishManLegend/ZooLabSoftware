namespace ZooLabLibrary.Animals.Reptiles
{
    public abstract class Reptile : Animal
    {
        public Reptile() { }
        public Reptile(bool isSick)
        {
            IsSick = isSick;
        }
    }
}
