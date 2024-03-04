using FastJobs.Domain.Entities;
using MediatR;

namespace FastJobs.Application.Companies.Commands.CreateCompany;

public class CreateCompanyCommand : IRequest<Guid>
{
    public Guid CompanyOwner { get; set; }
    public string CompanyDescription { get; set; } = string.Empty;
    public CompanyCategory CompanyCategory {get; set; }
    public string Address { get; set; } = string.Empty;  
}