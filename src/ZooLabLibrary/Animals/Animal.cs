using ZooLabLibrary.Animals.Medicines;

namespace ZooLabLibrary.Animals
{
    public abstract class Animal
    {
        public bool IsSick { get; set; }

        public abstract List<Medicine> NeededMedicine { get; set; }

        public abstract Animals Type { get; }



    }
}


