using ZooLabLibrary.Animals.Foods;
using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Mammals
{
    public class Bison : Mammal
    {
        public override Animals Type => Animals.Bison;
        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();
        public override List<Food> FavouriteFood => new() { new Grass() };
        public override int RequiredSpaceSqFt => 1000;
        public override List<Animals> FriendlyAnimals => new() { Animals.Elephant, Animals.Bison };

        public Bison() {}
        public Bison(bool isSick) : base(isSick)
        {
            IsSick = isSick;

            if (IsSick)
                NeededMedicine.Add(new Antibiotics());

        }
    }
}
