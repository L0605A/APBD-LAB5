

using WebApplication1.Model;

namespace WebApplication1.Database;

public class VisitDatabase
{
    public static List<Visit> visits = new List<Visit>()
    {
        new Visit(1,new DateTime(2024, 12, 7, 12, 30, 0), AnimalDatabase.animals.FirstOrDefault(a => a.Id == 1), "Sample", 150),
        new Visit(2,new DateTime(2024, 11, 4, 15, 20, 0), AnimalDatabase.animals.FirstOrDefault(a => a.Id == 1), "Sample", 100),
        new Visit(3,new DateTime(2024, 10, 15, 22, 35, 0), AnimalDatabase.animals.FirstOrDefault(a => a.Id == 2), "Sample", 1000),

    };
}