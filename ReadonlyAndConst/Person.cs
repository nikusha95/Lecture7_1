namespace ReadonlyAndConst;

public class Person
{
    private readonly string _firstName;
    private readonly string _lastName;

    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"FirstName:{_firstName} Lastname:{_lastName}");
    }
}