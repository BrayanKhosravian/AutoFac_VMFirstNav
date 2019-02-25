﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac_IoC.Factory;
using Autofac_IoC.ViewModels;
using Xamarin.Forms;

namespace Autofac_IoC.Services
{
    public class Navigator : INavigator
    {
        private readonly Lazy<INavigation> _navigation;
        private readonly IViewFactory _viewFactory;

        public Navigator(Lazy<INavigation> navigation, IViewFactory viewFactory)
        {
            _navigation = navigation;
            _viewFactory = viewFactory;
        }

        private INavigation Navigation
        {
            get
            {
                return _navigation.Value;
            }
        }

        public async Task PopAsync()
        {
            await Navigation.PopAsync();
        }

        public async Task PopToRootAsync()
        {
            await Navigation.PopToRootAsync();
        }

        public async Task PushAsync<TViewModel>() where TViewModel : class, IViewModel
        {
            var view = _viewFactory.Resolve<TViewModel>();
            await Navigation.PushAsync(view);
        }

        public async Task PushAsyncWithParameter<TViewModel>(NamedParameter parameter) where TViewModel : class, IViewModel
        {
            var view = _viewFactory.ResolveWithParameter<TViewModel>(parameter);
            await Navigation.PushAsync(view);
        }

        public Task PushAsyncWithParameters<TViewModel>(params NamedParameter[] parameter) where TViewModel : class, IViewModel
        {
            throw new NotImplementedException();
        }

        public async Task PushModalAsync<TViewModel>() where TViewModel : class, IViewModel
        {
            var view = _viewFactory.Resolve<TViewModel>();
            await Navigation.PushModalAsync(view);
        }

    }
}
