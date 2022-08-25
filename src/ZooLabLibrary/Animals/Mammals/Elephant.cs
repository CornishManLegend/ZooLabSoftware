using ZooLabLibrary.Animals.Foods;
using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Mammals
{
    public class Elephant : Mammal
    {

        public override Animals Type => Animals.Elephant;
        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();
        public override List<Food> FavouriteFood => new() { new Grass() };
        public override int RequiredSpaceSqFt => 1000;
        public override List<Animals> FriendlyAnimals =>
            new() { Animals.Elephant, Animals.Bison, Animals.Parrot, Animals.Turtle };


        public Elephant() {}
        public Elephant(bool isSick) : base(isSick)
        {
            IsSick = isSick;

            if (IsSick)
                NeededMedicine.Add(new Antibiotics());
        }
    }
}
