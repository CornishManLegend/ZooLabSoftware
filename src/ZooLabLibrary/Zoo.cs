using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Animals;
using ZooLabLibrary.Console;
using ZooLabLibrary.Employees;
using ZooLabLibrary.Enclosures;
using ZooLabLibrary.Exceptions;

namespace ZooLabLibrary
{
    public class Zoo
    {

        //public IConsole Console { get; set; } = new DefaultConsole();

        //public List<Enclosure> Enclosures { get; set; }

        //public List<IEmployee> Employees { get; set; }

        //public string Location { get; set; }

        //public Zoo(string location)
        //{
        //    Location = location;
        //    Enclosures = new List<Enclosure>();
        //    Employees = new List<IEmployee>();
        //}

        //public void HireEmployee(IEmployee employee)
        //{
        //    Employees.Add(employee);

        //    Console.WriteLine("Employee Petrov Ivan is hired as a veterinar1");
        //}

        //public void AddEnclosure(Enclosure enclosure)
        //{
        //    Enclosures.Add(enclosure);

        //    Console.WriteLine("New Enclosure added: " + enclosure.Name);
        //}

        //public Enclosure FindAvailableEnclosure(Animal animalWithoutEnclosure)
        //{
        //    foreach (var enclosure in Enclosures)
        //    {
        //        int availableSquare = enclosure.SquareFeet;

        //        foreach (var animal in enclosure.Animals)
        //        {
        //            if (animalWithoutEnclosure.IsFriendlyWithAnimal(animal))
        //                availableSquare -= animal.RequiredSpaceSqFt;
        //            else
        //                availableSquare = -1;
        //        }

        //        if (availableSquare >= animalWithoutEnclosure.RequiredSpaceSqFt)
        //        {

        //            return enclosure;
        //        }

        //    }

        //    throw new NoAvailableEnclosureException("There is no enclosure available");
        //}

    }
}
