using Microsoft.EntityFrameworkCore;

namespace CretaceousPark.Models
{
  public class CretaceousParkContext : DbContext
  {
    public CretaceousParkContext(DbContextOptions<CretaceousParkContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name="Derek", Species = "Velociraptor", Age = 23, Gender = "Male" },
          new Animal { AnimalId = 2, Name="Sasha", Species = "T Rex", Age = 4, Gender = "Female" },
          new Animal { AnimalId = 3, Name="Derek", Species = "T Rex", Age = 17, Gender = "Female" },
          new Animal { AnimalId = 4, Name="Bonecrusher", Species = "Chipmunk", Age = 65, Gender = "Female" },
          new Animal { AnimalId = 5, Name="Allen", Species = "Triceratops", Age = 9, Gender = "Male" }
        );
    }

    public DbSet<Animal> Animals { get; set; }
  }
}