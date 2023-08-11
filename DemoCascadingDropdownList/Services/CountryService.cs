using DemoCascadingDropdownList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCascadingDropdownList.Services
{
    internal class CountryService : ICountryService
    {
        public Task<List<City>> Cities()
        {
            List<City> cities = new List<City>()
            {
                new City(){Id = 1, Name = "Kumasi", CountryId = 1},
                new City(){Id = 2, Name = "Cape Coast", CountryId= 1},
                new City(){Id = 3, Name = "Sunyani", CountryId = 1},
                new City(){Id = 4, Name = "Berekum", CountryId= 1},
                new City(){Id = 5, Name = "Sege", CountryId = 1},
                new City(){Id = 6, Name = "Accra", CountryId= 1},
                new City(){Id = 7, Name = "Dawenya", CountryId = 1},
                new City(){Id = 8, Name = "Koforidua", CountryId= 1},
                new City(){Id = 9, Name = "Shama", CountryId = 1},
                new City(){Id = 10, Name = "Abuakwa", CountryId= 1},
                new City(){Id = 11, Name = "Lagos", CountryId= 2},
                new City(){Id = 12, Name = "Abuja", CountryId= 2},
            };
            return Task.FromResult(cities);
        }

        public Task<List<Country>> GetCountries()
        {
            List<Country> countries = new List<Country>()
           { 
                new Country(){  Id = 1, Name = "Ghana"},
            
                new Country() { Id = 2, Name = "Nigeria"}
            };
            return Task.FromResult(countries);
        }
    }
}
