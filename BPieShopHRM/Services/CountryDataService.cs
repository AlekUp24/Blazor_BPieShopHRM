using BPieShopHRM.Contracts.Repositories;
using BPieShopHRM.Contracts.Services;
using BethanysPieShopHRM.Shared.Domain;

namespace BPieShopHRM.Services
{
    public class CountryDataService : ICountryDataService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryDataService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
   
        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            return await _countryRepository.GetAllCountries();
        }

        public async Task<Country> GetCountryById(int countryId)
        {
            return await _countryRepository.GetCountryById(countryId);
        }
    }
}
