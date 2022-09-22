using ZooLabLibrary.Console;

namespace ZooLabLibrary.Employees;

public interface IEmployee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IConsole Console { get; set; }
}