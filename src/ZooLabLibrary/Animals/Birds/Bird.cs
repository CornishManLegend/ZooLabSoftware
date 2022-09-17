namespace ZooLabLibrary.Animals.Birds
{
    public abstract class Bird : Animal
    {
        protected Bird() {}

        protected Bird(bool isSick)
        {
            IsSick = isSick;
        }

        protected Bird(bool isSick, bool isHungry)
        {
            IsSick = isSick;
            IsHungry = isHungry;
        }
    }
}
