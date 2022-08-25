using ZooLabLibrary.Animals.Foods;
using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Reptiles
{
    public class Turtle : Reptile
    {
        public override Animals Type => Animals.Turtle;
        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();
        public override List<Food> FavouriteFood => new() { new Vegetable() };
        public override int RequiredSpaceSqFt => 5;
        public override List<Animals> FriendlyAnimals =>
            new() { Animals.Turtle, Animals.Parrot, Animals.Elephant, Animals.Bison };

        public Turtle() { }
        public Turtle(bool isSick) : base(isSick)
        {
            IsSick = isSick;
            if (IsSick)
                NeededMedicine.Add(new Antibiotics());
        }
    }
}
