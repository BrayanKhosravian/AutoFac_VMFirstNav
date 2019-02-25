using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using App1.Interfaces;
using App1.Services;
using Autofac_IoC.Interfaces;
using Xamarin.Forms;

namespace App1.ViewModels
{
    class Page3ViewModel : BaseViewModel
    {
        private readonly IPageService _pageService;
        private readonly IStringProvider _stringProvider;
        private readonly IUUIDService _uuidService;
        private readonly INavigation _navigation;

        public ICommand CommandStringProvider  { get; set; }
        public ICommand CommandUUIDService { get; set; }
        public ICommand CommandNextPage { get; set; }
        public ICommand CommandNavigateBack { get; set; }

        public Page3ViewModel(IPageService pageService, IStringProvider stringProvider,IUUIDService uuidService , INavigation navigation)
        {
            _pageService = pageService;
            _stringProvider = stringProvider;
            _uuidService = uuidService;
            _navigation = navigation;

            CommandStringProvider = new Command( async () => await _pageService.DisplayAlert(_stringProvider.GetString(),_stringProvider.GetString(), stringProvider.GetString()));
            CommandUUIDService = new Command(async () => await _pageService.DisplayAlert(_uuidService.GetUUID(), _uuidService.GetUUID(), _uuidService.GetUUID()));
            CommandNavigateBack = new Command(async () => await _navigation.PopAsync());
        }
    }
}
