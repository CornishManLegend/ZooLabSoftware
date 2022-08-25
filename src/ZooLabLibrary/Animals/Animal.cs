using ZooLabLibrary.Animals.Foods;
using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals
{
    public abstract class Animal
    {
        private static int _currentId = 1;
        public int Id { get; }
        public bool IsSick { get; set; }
        public abstract List<Medicine> NeededMedicine { get; set; }
        public abstract List<Animals> FriendlyAnimals { get; }
        public abstract List<Food> FavouriteFood { get; }
        public abstract int RequiredSpaceSqFt { get; }
        public abstract Animals Type { get; }

    }
}


