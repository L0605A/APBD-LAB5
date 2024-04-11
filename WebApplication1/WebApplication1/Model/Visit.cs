namespace WebApplication1.Model;

public class Visit
{
    public int Id { get; set; }
    
    public DateTime Date { get; set; }
    
    public Animal AnimalInQuestion { get; set; }
    
    public string Description { get; set; }
    
    public double Price { get; set; }

    public Visit(int id, DateTime date, Animal animalInQuestion, string description, double price)
    {
        Id = id;
        Date = date;
        AnimalInQuestion = animalInQuestion;
        Description = description;
        Price = price;
    }
}