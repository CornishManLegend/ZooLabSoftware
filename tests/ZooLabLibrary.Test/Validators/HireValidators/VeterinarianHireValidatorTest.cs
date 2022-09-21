using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ZooLabLibrary.Animals;
using ZooLabLibrary.Animals.Birds;
using ZooLabLibrary.Animals.Mammals;
using ZooLabLibrary.Animals.Reptiles;
using ZooLabLibrary.Employees;
using ZooLabLibrary.Enclosures;
using ZooLabLibrary.Validators.HireValidators;

namespace ZooLabLibrary.Test.Validators.HireValidators
{
    public class VeterinarianHireValidatorTest
    {
        [Fact]
        public void ShouldBeAbleToCreateVeterinarianHireValidator()
        {
            VeterinarianHireValidator veterinarianHireValidator = new VeterinarianHireValidator(new Zoo("New York"));
            Assert.NotNull(veterinarianHireValidator);
        }

        [Fact]
        public void ShouldBeAbleToValidateVeterinarianWhoHasExperiences()
        {
            List<Animal> animalExperiences = new List<Animal>() { new Parrot(), new Turtle(), new Elephant() };
            Veterinarian veterinarian = new Veterinarian("John", "Wayne", animalExperiences);
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Turtle(), new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 3000);
            zoo.AddEnclosure(enclosure);
            VeterinarianHireValidator veterinarianHireValidator = new VeterinarianHireValidator(zoo);
            Assert.Empty(veterinarianHireValidator.ValidateEmployee(veterinarian));
        }

        [Fact]
        public void ShouldBeAbleToValidateVeterinarianWhoHasNotExperiences()
        {
            List<Animal> animalExperiences = new List<Animal>() { new Parrot(), new Turtle(), new Elephant() };
            Veterinarian veterinarian = new Veterinarian("John", "Wayne", animalExperiences);
            Zoo zoo = new Zoo("New York");
            List<Animal> animalsList = new List<Animal>() { new Bison(), new Parrot(), new Elephant() };
            Enclosure enclosure = new Enclosure("test enclosure", animalsList, zoo, 3000);
            zoo.AddEnclosure(enclosure);
            VeterinarianHireValidator veterinarianHireValidator = new VeterinarianHireValidator(zoo);
            Assert.NotEmpty(veterinarianHireValidator.ValidateEmployee(veterinarian));
        }
    }
}
