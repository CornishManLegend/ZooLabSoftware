
namespace ZooLabLibrary.Animals.Mammals
{
    public class Bison : Mammal
    {
        public Bison() {}
        public Bison(bool isSick) : base(isSick)
        {
            IsSick = isSick;
        }
    }
}
