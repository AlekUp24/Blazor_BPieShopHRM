using BethanysPieShopHRM.Shared.Domain;

namespace BPieShopHRM.Contracts.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
    }
}
