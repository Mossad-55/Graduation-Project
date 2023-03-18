using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class RepositoryContext : IdentityDbContext<ApplicationUser>
{
	public RepositoryContext(DbContextOptions<RepositoryContext> options)
		: base(options)
	{

	}

    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        // modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
    }*/

    // DbSets Here.
}
