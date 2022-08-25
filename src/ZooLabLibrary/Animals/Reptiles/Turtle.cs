using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Reptiles
{
    public class Turtle : Reptile
    {
        public override Animals Type => Animals.Turtle;

        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();

        public Turtle() { }
        public Turtle(bool isSick) : base(isSick)
        {
            IsSick = isSick;
            if (IsSick)
                NeededMedicine.Add(new Antibiotics());
        }
    }
}
