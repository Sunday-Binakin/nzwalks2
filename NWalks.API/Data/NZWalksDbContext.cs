using Microsoft.EntityFrameworkCore;
using NWalks.API.Models.Domain;

namespace NWalks.API.Data;

public class NZWalksDbContext:DbContext
{
    public NZWalksDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
    {
        
    }

    public DbSet<Difficulty> Difficulties { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Walk> Walks { get; set; }
}