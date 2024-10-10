using BethanysPieShopHRM.Shared.Domain;

namespace BPieShopHRM.Contracts.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeDetails(int employeeId);
    }
}
