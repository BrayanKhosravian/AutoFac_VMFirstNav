using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac_IoC.ViewModels;

namespace Autofac_IoC.Services
{
    public interface INavigator
    {
        Task PopAsync();
        Task PopToRootAsync();
        Task PushAsync<TViewModel>() where TViewModel : class, IViewModel;
        Task PushAsyncWithParameter<TViewModel>(NamedParameter parameter) where TViewModel : class, IViewModel;
        Task PushAsyncWithParameters<TViewModel>(params NamedParameter[] parameter) where TViewModel : class, IViewModel;
        Task PushModalAsync<TViewModel>() where TViewModel : class, IViewModel;
    }
}
