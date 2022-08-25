using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Reptiles
{
    public class Snake : Reptile
    {
        public override Animals Type => Animals.Snake;
        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();

        public Snake() { }
        public Snake(bool isSick) : base(isSick)
        {
            IsSick = isSick;
            if (IsSick)
                NeededMedicine.Add(new Antibiotics());
        }
    }
}
