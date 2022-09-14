using ZooLabLibrary.Animals;


namespace ZooLabLibrary.Employees;

public class ZooKeeper : IEmployee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ZooKeeper(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}