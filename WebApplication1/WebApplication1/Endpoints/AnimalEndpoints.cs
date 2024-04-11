using WebApplication1.Database;
using WebApplication1.Model;

namespace WebApplication1.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals" , () =>
        {
            var animal = AnimalDatabase.animals;
            return Results.Ok(animal);
        });

        app.MapGet("/animals/{id}" , (int id) =>
        {
            foreach(var ele in AnimalDatabase.animals)
            {
                if (ele.Id == id)
                {
                    var animal = ele;
                    return Results.Ok(animal);
                }
            }

            return Results.NotFound();
        });

        app.MapPost("/animals" , (Animal animal) =>
        {
            AnimalDatabase.animals.Add(animal);
            return Results.Created("", animal);
        });

        app.MapPut("/animals/{id}", (int id, Animal updatedAnimal) =>
        {
            var existingAnimal = AnimalDatabase.animals.FirstOrDefault(a => a.Id == id);

            if (existingAnimal != null)
            {
                existingAnimal.Name = updatedAnimal.Name;
                existingAnimal.Category = updatedAnimal.Category;
                existingAnimal.Weight = updatedAnimal.Weight;
                existingAnimal.FurColor = updatedAnimal.FurColor;
                return Results.Ok(updatedAnimal);
            }
            return Results.NotFound();

        });



        app.MapDelete("/animals/{id}", (int id) =>
        {
            var animalToRemove = AnimalDatabase.animals.FirstOrDefault(a => a.Id == id);
            if (animalToRemove != null)
            {
                AnimalDatabase.animals.Remove(animalToRemove);
                return Results.Ok();
            }
            return Results.NotFound();
        });

    }
}