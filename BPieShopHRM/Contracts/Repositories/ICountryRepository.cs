using BethanysPieShopHRM.Shared.Domain;

namespace BPieShopHRM.Contracts.Repositories
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
