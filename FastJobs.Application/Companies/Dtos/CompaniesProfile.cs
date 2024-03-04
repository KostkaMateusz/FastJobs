using AutoMapper;
using FastJobs.Application.Companies.Commands.CreateCompany;
using FastJobs.Domain.Entities;

namespace FastJobs.Application.Companies.Dtos;

public class CompaniesProfile : Profile
{
    public CompaniesProfile()
    {
        CreateMap<CreateCompanyCommand, Company>();
    }
}