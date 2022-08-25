using ZooLabLibrary.Animals.Foods;
using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals.Reptiles
{
    public class Snake : Reptile
    {
        public override Animals Type => Animals.Snake;
        public override List<Medicine> NeededMedicine { get; set; } = new List<Medicine>();
        public override List<Food> FavouriteFood => new() { new Meat() };
        public override int RequiredSpaceSqFt => 2;
        public override List<Animals> FriendlyAnimals => new() { Animals.Snake };

        public Snake() { }
        public Snake(bool isSick) : base(isSick)
        {
            IsSick = isSick;
            if (IsSick)
                NeededMedicine.Add(new Antibiotics());
        }
    }
}
