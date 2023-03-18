using Contracts;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace GraduationProject_API.Extensions;

public static class ServiceExtensions
{
    // CORS Configuration.
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        });

    // IIS Configuration. (Default)
    public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options =>
        {
            // Multiple Options will be added later.
        });

    // Configure Logger Services.
    public static void ConfigureLoggerServices(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();

    // Configure the RepositoryContext at runtime.
    public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<RepositoryContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

    // Configuring IdentityUser
    public static void ConfigureIdentityUser(this IServiceCollection services) =>
        services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<RepositoryContext>();
        
}
