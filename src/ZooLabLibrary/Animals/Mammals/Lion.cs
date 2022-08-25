using ZooLabLibrary.Animals.Foods;
using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Mammals
{
    public class Lion : Mammal
    {
        public override Animals Type => Animals.Lion;
        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();
        public override List<Food> FavouriteFood => new() { new Meat() };
        public override int RequiredSpaceSqFt => 1000;
        public override List<Animals> FriendlyAnimals => new() { Animals.Lion };

        public Lion() {}
        public Lion(bool isSick) : base(isSick)
        {
            IsSick = isSick;

            if (IsSick)
                NeededMedicine.Add(new Antibiotics());

        }
    }
}
