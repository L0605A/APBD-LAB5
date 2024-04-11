

using WebApplication1.Model;

namespace WebApplication1.Database;

public class AnimalDatabase
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(1, "Walter", "Dog", 100, "White"),
        new Animal(2, "Sample", "Cat", 50, "Calico"),
        new Animal(3, "Sample", "Cat", 50, "Calico"),

    };
}