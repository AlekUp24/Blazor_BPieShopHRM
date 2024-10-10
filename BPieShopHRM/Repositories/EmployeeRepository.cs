using BethanysPieShopHRM.Shared.Domain;
using BPieShopHRM.Contracts.Repositories;
using BPieShopHRM.Data;
using Microsoft.EntityFrameworkCore;

namespace BPieShopHRM.Repositories
{
    public class EmployeeRepository : IEmployeeRepository, IDisposable
    {
        public readonly AppDbContext _appDbContext;

        public EmployeeRepository(IDbContextFactory<AppDbContext> DbFactory)
        {
            _appDbContext = DbFactory.CreateDbContext();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _appDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _appDbContext.Employees.FirstOrDefaultAsync(c => c.EmployeeId == employeeId);
        }
    }
}
