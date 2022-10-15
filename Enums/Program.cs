// See https://aka.ms/new-console-template for more information

using Enums;

int x = 10;

AnimalType t = (AnimalType)x;
var isEnum = Enum.IsDefined(typeof(AnimalType), x);
Enum.Parse<AnimalType>("Mammal", true);

Console.WriteLine(t.ToString());
Animal m = new Animal("m", AnimalType.Reptile);
