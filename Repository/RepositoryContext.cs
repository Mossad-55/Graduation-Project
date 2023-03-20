using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository;

public class RepositoryContext : DbContext
{
	public RepositoryContext(DbContextOptions options)
		: base(options)
	{

	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Applying Configuration For Each Entity.
        modelBuilder.ApplyConfiguration(new UniversityConfiguration());

    }

    // DbSets Here.
    public DbSet<University>? Universities { get; set; }
}
