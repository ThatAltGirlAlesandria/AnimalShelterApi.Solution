using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new DbContextOptionsBuilder { AnimalId = 1, AnimalType = "Dog", AnimalName = "Trash", MaleFemale = "Female", AnimalDescription = "They were found dumpster diving.", AnimalAge = 3 },
          new DbContextOptionsBuilder { AnimalId = 2, AnimalType = "Dog", AnimalName = "Nerd", MaleFemale = "Male", AnimalDescription = "Likes to do your taxes.", AnimalAge = 5 },
          new DbContextOptionsBuilder { AnimalId = 3, AnimalType = "Dog", AnimalName = "Illuminati", MaleFemale = "Unknown", AnimalDescription = "They are the Illuminati. Don't cross them or you'll be swimming with the fishes.", AnimalAge = 20 },
          new DbContextOptionsBuilder { AnimalId = 4, AnimalType = "Dog", AnimalName = "Womb", MaleFemale = "Female", AnimalDescription = "Big Gwyneth Paltrow fan.", AnimalAge = 18 },
          new DbContextOptionsBuilder { AnimalId = 5, AnimalType = "Dog", AnimalName = "Jimmy Chew", MaleFemale = "Male", AnimalDescription = "While he may be new to the fashion scene, he's known what he's wanted to do his whole life. Style you in the best outfits he can.", AnimalAge = 2 },
          new DbContextOptionsBuilder { AnimalId = 6, AnimalType = "Cat", AnimalName = "Wasabi", MaleFemale = "Male", AnimalDescription = "They think their a lot tougher than they are. Spicy outside, soft inside", AnimalAge = 5 },
          new DbContextOptionsBuilder { AnimalId = 7, AnimalType = "Cat", AnimalName = "Racoon", MaleFemale = "Male", AnimalDescription = "Was seen fraternizing with racoons. Bullied by other cats now.", AnimalAge = 1 },
          new DbContextOptionsBuilder { AnimalId = 8, AnimalType = "Cat", AnimalName = "Pi", MaleFemale = "Female", AnimalDescription = "Can rattle off over 300 variables from the Pi sequence and very proud of it.", AnimalAge = 314 },
          new DbContextOptionsBuilder { AnimalId = 9, AnimalType = "Cat", AnimalName = "Linux", MaleFemale = "Female", AnimalDescription = "Hacked into the CIA. We can't talk about it.", AnimalAge = 6 },
          new DbContextOptionsBuilder { AnimalId = 10, AnimalType = "Cat", AnimalName = "Richard", MaleFemale = "Male", AnimalDescription = "They are a tuxedo cat and believes that makes them better than everyone else, since they are always best dressed.", AnimalAge = 1 }
        );
    }
  }
}