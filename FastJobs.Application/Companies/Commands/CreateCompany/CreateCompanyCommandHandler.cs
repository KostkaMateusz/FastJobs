using MediatR;

namespace FastJobs.Application.Companies.Commands.CreateCompany;

public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand,Guid>
{
    public Task<Guid> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}