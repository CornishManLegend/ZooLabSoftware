using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Mammals
{
    public class Elephant : Mammal
    {

        public override Animals Type => Animals.Elephant;

        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();


        public Elephant() {}
        public Elephant(bool isSick) : base(isSick)
        {
            IsSick = isSick;

            if (IsSick)
                NeededMedicine.Add(new Antibiotics());
        }
    }
}
