using BethanysPieShopHRM.Shared.Domain;

namespace BPieShopHRM.Contracts.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
