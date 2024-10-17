using BethanysPieShopHRM.Shared.Domain;

namespace BPieShopHRM.Contracts.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
