using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;
    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

      [HttpGet]
      public async Task<ActionResult<IEnumerable<Animal>>> Get (string animalName, string animalDescription, string animalType, string maleFemale)
      {
        IQueryable<Animal> query = _db.Animals.AsQueryable();
        if (animalName != null)
        {
          query = query.Where(e => e.AnimalName == animalName);
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
        return await query.ToListAsync();
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

      [HttpPost]
      public async Task<ActionResult<Animal>> Post(Animal animal)
      {
        _db.Animals.Add(animal);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
      }

      [HttpPut("{id}")]
      public async Task<IActionResult> Put (int id, Animal animal)
      {
        if (id != animal.AnimalId)
        {
          return BadRequest();
        }
        _db.Animals.Update(animal);
        try
        {
          await _db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!AnimalExists(id))
          {
            return NotFound();
          }
          else
          {
            throw;
          }
        }
        return NoContent();
      }
      private bool AnimalExists(int id)
      {
        return _db.Animals.Any(e => e.AnimalId == id);
      }

      [HttpDelete("{id}")]
      public async Task<ActionResult> DeleteAnimal (int id)
      {
        Animal animal = await _db.Animals.FindAsync(id);
        if (animal == null)
        {
          return NotFound();
        }
        _db.Animals.Remove(animal);
        await _db.SaveChangesAsync();
        return NoContent();
    }
  }
}