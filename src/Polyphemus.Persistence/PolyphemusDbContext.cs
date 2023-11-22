namespace Kiwi.Polyphemus.Persistence;

using Kiwi.Polyphemus.Persistence.Model;

using Microsoft.EntityFrameworkCore;

public class PolyphemusDbContext : DbContext
{
  public PolyphemusDbContext(DbContextOptions<PolyphemusDbContext> options)
    : base(options)
  {
  }

  public DbSet<Patient> Patients { get; set; }
}
