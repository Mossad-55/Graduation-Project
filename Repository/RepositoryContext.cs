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
        modelBuilder.ApplyConfiguration(new FacultyConfiguration());
        modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new SubjectConfiguration());
    }

    // DbSets Here.
    public DbSet<University>? Universities { get; set; }
    public DbSet<Faculty>? Faculties { get; set; }
    public DbSet<Department>? Departments { get; set; }
    public DbSet<Subject>? Subjects { get; set; }
    public DbSet<Questionnaire>? Questionnaires { get; set; }
}
