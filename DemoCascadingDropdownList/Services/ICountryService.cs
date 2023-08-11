using DemoCascadingDropdownList.Models;

namespace DemoCascadingDropdownList.Services
{
    public interface ICountryService
    {
        Task<List<Country>> GetCountries();
        Task<List<City>> Cities();
    }
}
