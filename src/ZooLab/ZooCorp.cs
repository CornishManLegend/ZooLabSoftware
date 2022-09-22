using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary;
using ZooLabLibrary.Animals.Birds;
using ZooLabLibrary.Animals.Mammals;
using ZooLabLibrary.Animals.Reptiles;
using ZooLabLibrary.Animals;
using ZooLabLibrary.Console;
using ZooLabLibrary.Enclosures;
using ZooLabLibrary.Employees;

namespace ZooLab
{
    public class ZooCorp
    {

        public static void Main(string[] args)
        {
            ZooCorp zooCorp = new ZooCorp();
            zooCorp.Run(new DefaultConsole());
        }

        public void Run(IConsole MyConsole)
        {
            ZooApp zooApp = new ZooApp();
            zooApp.Console = MyConsole;

            Zoo zoo1 = new Zoo("Texas");
            zoo1.Console = MyConsole;
            Zoo zoo2 = new Zoo("Holliwood");
            zoo2.Console = MyConsole;

            zooApp.AddZoo(zoo1);
            zooApp.AddZoo(zoo2);

            for (int i = 1; i < 11; i++)
            {
                var zoo1enclosure = new Enclosure("Enclosure" + i, zoo1, 2000);
                zoo1enclosure.Console = MyConsole;
                var zoo2enclosure = new Enclosure("Enclosure" + i, zoo2, 2000);
                zoo2enclosure.Console = MyConsole;

                zoo1.AddEnclosure(zoo1enclosure);
                zoo2.AddEnclosure(zoo2enclosure);
            }

            var zoo1animals = new List<Animal>()
            {
                new Parrot(iD: 1, isSick: true, isHungry: true),
                new Penguin(iD: 2, isSick: true, isHungry: true),
                new Bison(iD: 3, isSick: true, isHungry: true),
                new Elephant(iD: 4, isSick: true, isHungry: true),
                new Lion(iD: 5, isSick: true, isHungry: true),
                new Snake(iD: 6, isSick: true, isHungry: true),
                new Turtle(iD: 7, isSick: true, isHungry: true),

            };

            var zoo2animals = new List<Animal>()
            {
                new Parrot(iD: 1, isSick: true, isHungry: true),
                new Penguin(iD: 2, isSick: true, isHungry: true),
                new Bison(iD: 3, isSick: true, isHungry: true),
                new Elephant(iD: 4, isSick: true, isHungry: true),
                new Lion(iD: 5, isSick: true, isHungry: true),
                new Snake(iD: 6, isSick: true, isHungry: true),
                new Turtle(iD: 7, isSick: true, isHungry: true),
            };

            foreach (var animal in zoo1animals)
            {
                zoo1.FindAvailableEnclosure(animal).AddAnimals(animal);
            }
            foreach (var animal in zoo2animals)
            {
                zoo2.FindAvailableEnclosure(animal).AddAnimals(animal);
            }

            var experiences = new List<Animal>()
            {
                new Parrot(),
                new Penguin(),
                new Bison(),
                new Elephant(),
                new Lion(),
                new Snake(),
                new Turtle(),
            };

            var zoo1employees = new List<IEmployee>()
            {
                new Veterinarian("Ben", "Gunn", experiences),
                new Veterinarian("Jim", "Hawkins", experiences) ,
                new ZooKeeper("John", "Trelawney", experiences) ,
                new ZooKeeper("David", "Livesey", experiences)
            };

            var zoo2employees = new List<IEmployee>()
            {
                new Veterinarian("Billy", "Bones", experiences),
                new Veterinarian("John", "Silver", experiences) ,
                new ZooKeeper("David", "Pew", experiences) ,
                new ZooKeeper("Job", "Anderson", experiences)
            };


            foreach (var employee in zoo1employees)
            {
                employee.Console = MyConsole;
                zoo1.HireEmployee(employee);
            }
            foreach (var employee in zoo2employees)
            {
                employee.Console = MyConsole;
                zoo2.HireEmployee(employee);
            }

            zoo1.FeedAnimals();
            zoo1.HealAnimals();

            zoo2.FeedAnimals();
            zoo2.HealAnimals();
        }
    }
}
