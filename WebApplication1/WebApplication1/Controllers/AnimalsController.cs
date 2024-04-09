using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("/animals-controller")]
//[Route("[controller]")]

public class AnimalsController : ControllerBase
{
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();
    }
    
    
    [HttpGet("{id")]
    public IActionResult GetAnimals(int id)
    {
        return Ok(id);
    }
    
    [HttpPost]
    public IActionResult AddAnimal()
    {
        return Created();
    }
    
    [HttpPut("{id")]
    public IActionResult EditAnimal()
    {
        return Ok();
    }
    
    [HttpDelete("{id")]
    public IActionResult DeleteAnimal()
    {
        return Ok();
    }
    
    
}