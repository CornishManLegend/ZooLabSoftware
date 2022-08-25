using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Birds
{
    public class Penguin : Bird
    {
        public override Animals Type => Animals.Penguin;
        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();

        public Penguin() { }
        public Penguin(bool isSick) : base(isSick)
        {
            IsSick = isSick;

            if (isSick)
                NeededMedicine.Add(new AntiInflammatory());
        }
    }
}
