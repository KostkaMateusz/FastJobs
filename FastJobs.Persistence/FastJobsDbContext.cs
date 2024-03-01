using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace FastJobs.Persistence;

public class FastJobsDbContext(DbContextOptions<FastJobsDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}