using WebApplication1.Database;
using WebApplication1.Model;

namespace WebApplication1.Endpoints;

public static class VisitEndpoints
{
    public static void MapVisitEndpoints(this WebApplication app)
    {

        app.MapGet("/visits/{id}" , (int id) =>
        {
            List<Visit> validVisits = new List<Visit>();
            
            foreach(var ele in VisitDatabase.visits)
            {
                if (ele.AnimalInQuestion.Id == id)
                {
                    var visit = ele;
                    validVisits.Add(visit);
                }
            }

            if (validVisits.Count > 0)
            {
                return Results.Ok(validVisits);
            }

            return Results.NotFound();
        });

        app.MapPost("/visits" , (Visit visit) =>
        {
            VisitDatabase.visits.Add(visit);
            return Results.Created("", visit);
        });


    }
}