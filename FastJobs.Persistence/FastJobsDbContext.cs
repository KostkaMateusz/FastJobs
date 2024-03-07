using System.Reflection;
using FastJobs.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastJobs.Persistence;

public class FastJobsDbContext(DbContextOptions<FastJobsDbContext> options) : DbContext(options)
{
    internal DbSet<Company>? Companies { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}