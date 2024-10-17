using BPieShopHRM.Contracts.Repositories;
using BPieShopHRM.Data;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BPieShopHRM.Repositories
{
    public class JobCategoryRepository : IJobCategoryRepository, IDisposable
    {
        private readonly AppDbContext _appDbContext;

        //public JobCategoryRepository(AppDbContext appDbContext)
        //{
        //    _appDbContext = appDbContext;
        //}

        public JobCategoryRepository(IDbContextFactory<AppDbContext> DbFactory)
        {
            _appDbContext = DbFactory.CreateDbContext();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }

        public async Task<IEnumerable<JobCategory>> GetAllJobCategories()
        {
            return await Task.FromResult(_appDbContext.JobCategories);
        }

        public async Task<JobCategory> GetJobCategoryById(int jobCategoryId)
        {
            return await _appDbContext.JobCategories.FirstOrDefaultAsync(c => c.JobCategoryId == jobCategoryId);
        }
    }
}
