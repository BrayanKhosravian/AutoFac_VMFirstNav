using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Autofac;
using Autofac.Core;
using Autofac_IoC.ViewModels;
using Xamarin.Forms;

namespace Autofac_IoC.Factory
{
    public interface IViewFactory
    {
        void Register<TViewModel, TView>()
            where TViewModel : class, IViewModel
            where TView : Page;

        Page Resolve<TViewModel>() where TViewModel : class, IViewModel;
        Page ResolveWithParameter<TviewModel>(NamedParameter parameter) where TviewModel : class, IViewModel;
        Page ResolveWithParameters<TviewModel>(params Parameter[] parameters) where TviewModel : class, IViewModel;
    }
}
