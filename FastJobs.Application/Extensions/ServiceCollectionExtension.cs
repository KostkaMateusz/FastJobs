using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace FastJobs.Application.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        var applicationAssembly = typeof(ServiceCollectionExtension).Assembly;
        
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(applicationAssembly);
        });
        
        services.AddAutoMapper(applicationAssembly);

        services.AddValidatorsFromAssembly(applicationAssembly).AddFluentValidationAutoValidation();
        
        return services;
    }
}