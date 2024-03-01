namespace FastJobs.Domain.Entities;

public class Company
{
    public Guid CompanyId { get; set; }
    public Guid CompanyOwner { get; set; }
    public string CompanyDescription { get; set; } = string.Empty;
    public CompanyCategory CompanyCategory {get; set; }
    public string Address { get; set; } = string.Empty;  
} 