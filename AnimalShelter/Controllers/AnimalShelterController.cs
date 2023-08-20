using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [ApiController]
  [Route("api/animalshelter/[controller]")]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;
    public AnimalsController(AnimalShelterContext db)
  }
  {
    _db = db;
  }
  [HttpGet]
  public async Task<ActionResult<IEnumerable<AnimalShelter>>> Get (int animalId, string animalName, string animalDescription, string animalType, string maleFemale, int animalAge)
  {
    IQueryable<Animal> query = _db.Animals.AsQueryable();
    if (animalId !- null)
    {
      query = query.Where(e => e.AnimalId == animalId);
    }
    if (animalName != null)
    {
      query = query.Where(e => e.AnimalName == name);
    }
    if (animalDescription != null)
    {
      query = query.Where(e => e.AnimalDescription == animalDescription);
    }
    if (animalType != null)
    {
      query = query.Where(e => e.AnimalType == animalType);
    }
    if (animalType != null)
    {
      query = query.Where(e => e.MaleFemale == maleFemale);
    }
    if (animalAge != null)
    {
      query = query.Where(e => e.AnimalAge == animalAge);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }
      return animal;
    }
  }
}