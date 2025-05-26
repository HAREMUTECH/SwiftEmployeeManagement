using SwiftEmployeeManagement.Domain.Enums;

namespace SwiftEmployeeManagement.Domain.Enitities;
public class Employee : BaseEntity
{
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
    public string PersonalEmail { get; set; }
    public string? WorkEmail { get; set; }
    public string? CountryCode { get; set; }
    public string PhoneNumber { get; set; }
    public string? DateOfBirth { get; set; }
    public int? MaritalStatus { get; set; }
    public int? Gender { get; set; }
    public string EmployeeNumber { get; set; }
    public string BVN { get; set; }
    public string Religion { get; set; }
    public int EmploymentStatus { get; set; }
    public string? ProfileImage { get; set; }
    public bool SelfServiceEnabled { get; set; }
    public bool AccountCreated { get; set; }
    public Guid UserId { get; set; }
    public Guid CompanyId { get; set; }
    public ConnectivityAvailablity ConnectivityAvailablity { get; set; }
    public ApplicationUser User { get; set; }
    public ContractType ContractType { get; set; }
}
