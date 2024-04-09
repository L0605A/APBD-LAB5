using WebApplication1.Database;
using WebApplication1.Model;

namespace WebApplication1.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals" , () =>
        {
            var animal = StaticData.animals;
            return Results.Ok(animal);
        });

        app.MapGet("/animals/{id}" , (int id) =>
        {
            foreach(var ele in StaticData.animals)
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
            
            return Results.Created("", animal);
        });

        app.MapPut("/animals/{id}" , (int id) =>
        {

            return Results.Ok();
        });


        app.MapDelete("/animals/{id}" , (int id) =>
        {

            return Results.Ok();
        });
    }
}