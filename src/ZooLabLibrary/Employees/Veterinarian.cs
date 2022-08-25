
namespace ZooLabLibrary.Employees;


public class Veterinarian : IEmployee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Veterinarian(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }


    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}