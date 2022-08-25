using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Mammals
{
    public class Bison : Mammal
    {
        public override Animals Type => Animals.Bison;

        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();

        public Bison() {}
        public Bison(bool isSick) : base(isSick)
        {
            IsSick = isSick;

            if (IsSick)
                NeededMedicine.Add(new Antibiotics());

        }
    }
}
