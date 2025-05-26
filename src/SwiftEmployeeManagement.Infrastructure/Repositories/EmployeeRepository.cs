using SwiftEmployeeManagement.Application.Abstractions.Repositories;
using SwiftEmployeeManagement.Application.Dtos.EmployeeDtos;

namespace SwiftEmployeeManagement.Infrastructure.Repositories;
public class EmployeeRepository : IEmployeeRepository
{
    public Task AddEmployeeAsync(CreateEmployeeDto employee)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEmployeeAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeDto> GetEmployeeByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateEmployeeAsync(UpdateEmployeeDto employee)
    {
        throw new NotImplementedException();
    }
}

