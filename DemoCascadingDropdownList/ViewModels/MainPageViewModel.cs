
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DemoCascadingDropdownList.Models;
using DemoCascadingDropdownList.Services;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCascadingDropdownList.ViewModels
{
    public partial class MainPageViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        private readonly ICountryService countryService;

        [ObservableProperty]
        private City _selectedCity;

        [ObservableProperty]
        bool _isCityEnabled;

        private Country _selectedCountry;
        public Country SelectedCountry
        {
            get => _selectedCountry;
            set
            {
                if (_selectedCountry != value)
                {
                    _selectedCountry = value;

                    IsCityEnabled = true;
                    LoadCities();
                }
            }
        }

        
        public ObservableRangeCollection<Country> Countries { get; set; } = new();
        public ObservableRangeCollection<City> Cities { get; set; } = new();
        public MainPageViewModel(ICountryService countryService)
        {
            this.countryService = countryService;
            IsCityEnabled = false;
            LoadCountries();
        }

        private async void LoadCountries()
        {
            var countries = await this.countryService.GetCountries();
            if (countries is null)
                return;

            if (Countries.Count > 0)
                Countries.Clear();
            Countries.AddRange(countries);
        }

        public async void DisplayItem()
        {
            await Shell.Current.DisplayAlert("Selected city", SelectedCity.Name, "Ok");
        }

        public async void LoadCities()
        {
            var cities = await this.countryService.Cities();
            if (cities is null)
                return;

            if (Cities.Count > 0)
                Cities.Clear();

            Cities.AddRange(cities.Where(i => i.CountryId == SelectedCountry.Id).ToList());
        }

        [RelayCommand]
        public  void DisplaySeletedCity()
        {
            if (SelectedCity != null)
                Shell.Current.DisplayAlert("Selected City", SelectedCity.Name, "Ok");
        }
    }
}
