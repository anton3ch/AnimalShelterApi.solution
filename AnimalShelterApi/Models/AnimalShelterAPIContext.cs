using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Models
{
  public class AnimalShelterAPIContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterAPIContext(DbContextOptions<AnimalShelterAPIContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Jack", Breed = "Golden Retriever", Age = 7 },
          new Animal { AnimalId = 2, Name = "Rex", Breed = "Mix", Age = 10 },
          new Animal { AnimalId = 3, Name = "Zoe", Breed = "Sphinx", Age = 2 },
          new Animal { AnimalId = 4, Name = "Maui", Breed = "Doberman", Age = 4 }
        );
    }
  }
}
