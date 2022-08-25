using ZooLabLibrary.Animals.Foods;
using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Birds
{
    public class Penguin : Bird
    {
        public override Animals Type => Animals.Penguin;
        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();
        public override List<Food> FavouriteFood => new() { new Vegetable() };
        public override int RequiredSpaceSqFt => 10;
        public override List<Animals> FriendlyAnimals => new() { Animals.Penguin };

        public Penguin() { }
        public Penguin(bool isSick) : base(isSick)
        {
            IsSick = isSick;

            if (isSick)
                NeededMedicine.Add(new AntiInflammatory());
        }
    }
}
