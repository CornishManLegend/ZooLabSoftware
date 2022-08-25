using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Mammals
{
    public class Lion : Mammal
    {
        public override Animals Type => Animals.Lion;
        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();

        public Lion() { }
        public Lion(bool isSick) : base(isSick)
        {
            IsSick = isSick;

            if (IsSick)
                NeededMedicine.Add(new Antibiotics());

        }
    }
}
