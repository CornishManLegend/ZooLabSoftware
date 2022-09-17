using ZooLabLibrary;
using ZooLabLibrary.Animals;
using ZooLabLibrary.Animals.Birds;
//using ZooLabLibrary.Animals.Mammals;
//using ZooLabLibrary.Animals.Reptiles;
using ZooLabLibrary.Console;
using ZooLabLibrary.Enclosures;

class Program
{
    static void Main(string[] args)
    {
        ZooCorp zooCorp = new ZooCorp();
        //zooCorp.Run(new DefaultConsole());
    }
}


public class ZooCorp
{
    //public void Run(IConsole console)
    //{
    //    ZooApp zooApp = new ZooApp();
    //    zooApp.Console = console;

    //    Zoo zoo1 = new Zoo("Texas");
    //    zoo1.Console = console;
    //    Zoo zoo2 = new Zoo("Holliwood");
    //    zoo2.Console = console;

    //    zooApp.AddZoo(zoo1);
    //    zooApp.AddZoo(zoo2);


    //    for (int i = 0; i < 10; i++)
    //    {
    //        var enclosure = new Enclosure("Zoo1 enclosure #" + (i + 1), zoo1, 2000);
    //        enclosure.Console = console;

    //        zoo1.AddEnclosure(enclosure);

    //    }

    //    for (int i = 0; i < 10; i++)
    //    {
    //        var enclosure = new Enclosure("Zoo2 enclosure #" + (i + 1), zoo2, 2000);
    //        enclosure.Console = console;

    //        zoo2.AddEnclosure(enclosure);

    //    }

    //    var animalsList1 = new List<Animal>()
    //        { new Parrot(isSick: true), new Bison(isSick: true), new Elephant(isSick: true), new Lion(isSick: true), new Turtle(isSick: true), new Snake(isSick: true), new Penguin(isSick: true) };
    //    var animalsList2 = new List<Animal>()
    //        { new Parrot(isSick: true), new Bison(isSick: true), new Elephant(isSick: true), new Lion(isSick: true), new Turtle(isSick: true), new Snake(isSick: true), new Penguin(isSick: true) };


    //    foreach (var animal in animalsList1)
    //    {
    //        zoo1.FindAvailableEnclosure(animal).AddAnimal(animal);
    //    }

    //    foreach (var animal in animalsList2)
    //    {
    //        zoo1.FindAvailableEnclosure(animal).AddAnimal(animal);
    //    }

    }
}