using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class RepositoryContext : DbContext
{
	public RepositoryContext(DbContextOptions options)
		: base(options)
	{

	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        // modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
    }

    // DbSets Here.
    public DbSet<University>? Universities { get; set; }
}
