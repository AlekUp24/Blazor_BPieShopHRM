using BPieShopHRM.Contracts.Repositories;
using BPieShopHRM.Contracts.Services;
using BethanysPieShopHRM.Shared.Domain;

namespace BPieShopHRM.Services
{
    public class JobCategoryDataService : IJobCategoryDataService
    {
        private readonly IJobCategoryRepository _jobCategoryRepository;

        public JobCategoryDataService(IJobCategoryRepository jobCategoryRepository)
        {
            _jobCategoryRepository = jobCategoryRepository;
        }

        public async Task<IEnumerable<JobCategory>> GetAllJobCategories()
        {
            return await _jobCategoryRepository.GetAllJobCategories();
        }

        public async Task<JobCategory> GetJobCategoryById(int jobCategoryId)
        {
            return await _jobCategoryRepository.GetJobCategoryById(jobCategoryId);
        }
    }
}
