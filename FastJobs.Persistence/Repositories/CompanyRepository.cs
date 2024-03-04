using FastJobs.Application.Contracts.Persistence;
using FastJobs.Domain.Entities;

namespace FastJobs.Persistence.Repositories;


public class CompanyRepository(FastJobsDbContext dbContext) : BaseRepository<Company>(dbContext) , ICompanyRepository
{
    
}
