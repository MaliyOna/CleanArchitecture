using CleanArchitecture.Enterprise.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<CatEntity> Cats { get; set; }
    public DbSet<FarmEntity> Farms { get; set; }
}
