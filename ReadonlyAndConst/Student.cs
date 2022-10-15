namespace ReadonlyAndConst;

public class Student
{
    private readonly string _firstName;
    private readonly string _lastName;
    private const int Numofsubject = 5;

    public Student(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }
}