using FastJobs.Application.Contracts.Persistence;
using FastJobs.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FastJobs.Persistence.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var dbConnectionString = configuration.GetConnectionString("FastJobsDbConnectionString");

        services.AddDbContext<FastJobsDbContext>(options =>
        {
            options.UseSqlServer(dbConnectionString);
        });

        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        
        return services;
    }
}