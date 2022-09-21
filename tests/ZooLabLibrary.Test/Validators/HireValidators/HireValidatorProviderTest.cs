using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Console;
using ZooLabLibrary.Employees;
using ZooLabLibrary.Validators.HireValidators;

namespace ZooLabLibrary.Test.Validators.HireValidators
{
    public class HireValidatorProviderTest
    {
        [Fact]
        public void ShouldBeAbleToCreateHireValidatorProvider()
        {
            HireValidatorProvider hireValidatorProvider = new HireValidatorProvider(new Zoo("New York"));
            Assert.NotNull(hireValidatorProvider);
        }

        [Fact]
        public void ShouldBeAbleToGetHireValidatorForZooKeeper()
        {
            Zoo zoo = new Zoo("New York");
            ZooKeeper zooKeeper = new ZooKeeper("John", "Wayne");
            HireValidatorProvider hireValidatorProvider = new HireValidatorProvider(zoo);
            var zooKeeperHireValidator = hireValidatorProvider.GetHireValidator(zooKeeper);
            Assert.Equal("ZooKeeperHireValidator", zooKeeperHireValidator.GetType().Name);
        }

        [Fact]
        public void ShouldBeAbleToGetHireValidatorForVeterinarian()
        {
            Zoo zoo = new Zoo("New York");
            Veterinarian veterinarian = new Veterinarian("John", "Wayne");
            HireValidatorProvider hireValidatorProvider = new HireValidatorProvider(zoo);
            var veterinarianHireValidator = hireValidatorProvider.GetHireValidator(veterinarian);
            Assert.Equal("VeterinarianHireValidator", veterinarianHireValidator.GetType().Name);
        }

        [Fact]
        public void ShouldBeAbleToGetHireValidatorForUndefinedEmployee()
        {
            Zoo zoo = new Zoo("New York");
            UndefinedEmployee undefinedEmployee = new UndefinedEmployee("John", "Wayne");
            HireValidatorProvider hireValidatorProvider = new HireValidatorProvider(zoo);
            //var ex = Assert.Throws<ArgumentException>(() => zoo.HireEmployee(undefinedEmployee));
            var ex = Assert.Throws<ArgumentException>(() => hireValidatorProvider.GetHireValidator(undefinedEmployee));
            Assert.Equal("Undefined employee detected " + undefinedEmployee.GetType().Name, ex.Message);
        }

        class UndefinedEmployee : IEmployee
        {
            public string FirstName { get; set; } = "FirstName";
            public string LastName { get; set; } = "LastName";
            public UndefinedEmployee(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }

    }
}
