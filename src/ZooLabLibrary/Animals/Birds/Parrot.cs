using ZooLabLibrary.Animals.Medicines;
using ZooLabLibrary.Animals.Foods;
using ZooLabLibrary.Console;
using System.Linq;

namespace ZooLabLibrary.Animals.Birds
{
    public class Parrot : Bird
    {
        private static readonly string[] _friendlyAnimals = new string[]
        {
                "Parrot",
                "Bison",
                "Elephant",
                "Turtle"
        };

        public Parrot() { }
        public Parrot(bool isSick) : base(isSick)
        {
            IsSick = isSick;
        }

        public Parrot(bool isSick, bool isHungry) : base(isSick, isHungry)
        {
            IsSick = isSick;
            IsHungry = isHungry;
        }

        public override int RequiredSpaceSqFt { get; } = 5;
        public override string[] FavouriteFood { get; } = new string[] { "Vegetable" };

        public override bool IsSick { get; set; }

       

        public override bool IsFriendlyWith(Animal animal)
        {
            return _friendlyAnimals.Contains(animal.GetType().Name);
        }

        public override void Feed(Food food) 
        { 
            if(IsHungry == true && FavouriteFood.Contains(food.FoodType))
                IsHungry = false;
        }

        public override void Heal(Medicine medicine) 
        {
            if (this.IsSick == true && medicine.MedicineType == "AntiDepression")
                IsSick = false;
        }

    }

}
