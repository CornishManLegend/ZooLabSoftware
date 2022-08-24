namespace ZooLabLibrary.Animals.Reptiles
{
    public class Snake : Reptile
    {
        public Snake() { }
        public Snake(bool isSick) : base(isSick)
        {
            IsSick = isSick;
        }
    }
}
