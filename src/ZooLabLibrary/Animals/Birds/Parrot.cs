using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Birds
{
    public class Parrot : Bird
    {
        public override Animals Type => Animals.Parrot;
        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();
        public Parrot() {}
        public Parrot(bool isSick) : base(isSick)
        {
            IsSick = isSick;

            if (IsSick)
                NeededMedicine.Add(new AntiDepression());

        }

    }
}
