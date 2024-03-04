using AutoMapper;
using FastJobs.Application.Contracts.Persistence;
using FastJobs.Domain.Entities;
using MediatR;

namespace FastJobs.Application.Companies.Commands.CreateCompany;

public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand,Guid>
{
    private readonly ICompanyRepository _companyRepository;
    private readonly IMapper _mapper;

    public CreateCompanyCommandHandler(ICompanyRepository companyRepository, IMapper mapper)
    {
        _companyRepository = companyRepository;
        _mapper = mapper;
    }
    
    public async Task<Guid> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        var company=_mapper.Map<Company>(request);

        var companyId=await _companyRepository.AddAsync(company);
        
        return companyId.CompanyId;
    }
}