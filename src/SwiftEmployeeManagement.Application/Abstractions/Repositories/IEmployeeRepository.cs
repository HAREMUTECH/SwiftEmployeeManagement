using SwiftEmployeeManagement.Application.Dtos.EmployeeDtos;

namespace SwiftEmployeeManagement.Application.Abstractions.Repositories;

public interface IEmployeeRepository
{
    Task<EmployeeDto> GetEmployeeByIdAsync(Guid id);
    Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync();
    Task AddEmployeeAsync(CreateEmployeeDto employee);
    Task UpdateEmployeeAsync(UpdateEmployeeDto employee);
    Task DeleteEmployeeAsync(Guid id);
}
