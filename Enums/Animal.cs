namespace Enums;

public class Animal
{
    private readonly string name;
    private readonly AnimalType type;

    public Animal(string name, AnimalType type)
    {
        this.name = name;
        this.type = type;
    }

    public void Print()
    {
        if (type == AnimalType.Amphibian)
        {
            Console.WriteLine("Is Amphibian");
        }
    }
}