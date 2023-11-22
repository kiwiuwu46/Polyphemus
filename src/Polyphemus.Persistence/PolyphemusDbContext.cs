namespace Kiwi.Polyphemus.Persistence;

using Kiwi.Polyphemus.Persistence.Model;

using Microsoft.EntityFrameworkCore;

public class PolyphemusDbContext : DbContext
{
  public PolyphemusDbContext(DbContextOptions<PolyphemusDbContext> options)
    : base(options)
  {
  }

  public PolyphemusDbContext()
  {
  }

  public DbSet<Patient> Patients { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    if (!optionsBuilder.IsConfigured)
    {
      optionsBuilder.UseSqlite("Data Source=:memory:;New=True;");
    }

    base.OnConfiguring(optionsBuilder);
  }
}
