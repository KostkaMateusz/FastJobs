using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FastJobs.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var dbConnectionString = configuration.GetConnectionString("FastJobsDbConnectionString");

        services.AddDbContext<FastJobsDbContext>(options =>
        {
            options.UseSqlServer(dbConnectionString);
        });

        // services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
        
        return services;
    }
}