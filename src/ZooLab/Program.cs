using ZooLabLibrary;
using ZooLabLibrary.Animals;
using ZooLabLibrary.Animals.Birds;
using ZooLabLibrary.Animals.Mammals;
using ZooLabLibrary.Animals.Reptiles;
using ZooLabLibrary.Console;
using ZooLabLibrary.Enclosures;

class Program
{
    static void Main(string[] args)
    {
        ZooCorp zooCorp = new ZooCorp();
        zooCorp.Run(new DefaultConsole());
    }
}


public class ZooCorp
{
    public void Run(IConsole console)
    {
        ZooApp zooApp = new ZooApp();
        zooApp.Console = console;

        Zoo zoo1 = new Zoo("Texas");
        zoo1.Console = console;
        Zoo zoo2 = new Zoo("Holliwood");
        zoo2.Console = console;

        zooApp.AddZoo(zoo1);
        zooApp.AddZoo(zoo2);


        var enclosure1 = new Enclosure("Enclosure for Penguin", zoo1, 10);
        enclosure1.Console = console;
        var enclosure2 = new Enclosure("Enclosure for Parrot", zoo1, 5);
        enclosure2.Console = console;
        var enclosure3 = new Enclosure("Enclosure for Elephant", zoo1, 1000);
        enclosure3.Console = console;
        var enclosure4 = new Enclosure("Enclosure for Lion", zoo1, 1000);
        enclosure4.Console = console;
        var enclosure5 = new Enclosure("Enclosure for Bison", zoo1, 1000);
        enclosure5.Console = console;
        var enclosure6 = new Enclosure("Enclosure for Snake", zoo1, 2);
        enclosure6.Console = console;
        var enclosure7 = new Enclosure("Enclosure for Turtle", zoo1, 5);
        enclosure7.Console = console;
        zoo1.AddEnclosure(enclosure1);
        zoo1.AddEnclosure(enclosure2);
        zoo1.AddEnclosure(enclosure3);
        zoo1.AddEnclosure(enclosure4);
        zoo1.AddEnclosure(enclosure5);
        zoo1.AddEnclosure(enclosure6);
        zoo1.AddEnclosure(enclosure7);
        zoo2.AddEnclosure(enclosure1);
        zoo2.AddEnclosure(enclosure2);
        zoo2.AddEnclosure(enclosure3);
        zoo2.AddEnclosure(enclosure4);
        zoo2.AddEnclosure(enclosure5);
        zoo2.AddEnclosure(enclosure6);
        zoo2.AddEnclosure(enclosure7);


        var animals1 = new List<Animal>()
            { new Parrot(isSick: true), new Bison(isSick: true), new Elephant(isSick: true), new Lion(isSick: true), new Turtle(isSick: true), new Snake(isSick: true), new Penguin(isSick: true) };
        var animals2 = new List<Animal>()
            { new Parrot(isSick: true), new Bison(isSick: true), new Elephant(isSick: true), new Lion(isSick: true), new Turtle(isSick: true), new Snake(isSick: true), new Penguin(isSick: true) };


    }
}