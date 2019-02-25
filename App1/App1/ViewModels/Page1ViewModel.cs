using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using App1.Services;
using App1.Views;
using Autofac;
using Autofac_IoC.Services;
using Xamarin.Forms;

namespace App1.ViewModels
{
    class Page1ViewModel : BaseViewModel
    {
        private readonly IPageService _pageService;
        private readonly INavigator _navigator;

        public ICommand CommandExecute { get; set; }
        public ICommand CommandNextPage { get; set; }

        public Page1ViewModel(INavigator navigator, IPageService pageService)
        {
            _navigator = navigator;
            _pageService = pageService;
            
            
            CommandExecute = new Command( async () => await _pageService.DisplayAlert("as","sadasd","sd"));
            CommandNextPage = new Command( async () => await _navigator.PushAsyncWithParameter<Page2ViewModel>(new NamedParameter("test","12345")));
        }
    }
}
