using BethanysPieShopHRM.Shared.Domain;

namespace BPieShopHRM.Contracts.Repositories
{
    public interface IJobCategoryRepository
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
