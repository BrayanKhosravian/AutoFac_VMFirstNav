using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Core;
using Autofac_IoC.ViewModels;
using Xamarin.Forms;

namespace Autofac_IoC.Factory
{
    class ViewFactory : IViewFactory
    {
        private readonly IDictionary<Type, Type> _map = new Dictionary<Type, Type>();
        private readonly IComponentContext _componentContext;

        public ViewFactory(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public void Register<TViewModel, TView>() 
            where TViewModel : class, IViewModel
            where TView : Page
        {
            _map[typeof(TViewModel)] = typeof(TView);
        }

        public Page Resolve<TViewModel>() where TViewModel : class, IViewModel
        {
            TViewModel viewModel = _componentContext.Resolve<TViewModel>();
            var viewType = _map[typeof(TViewModel)];
            var view = _componentContext.Resolve(viewType) as Page;

            view.BindingContext = viewModel;
            return view;
        }

        public Page ResolveWithParameter<TviewModel>(NamedParameter parameter) where TviewModel : class, IViewModel
        {
            TviewModel viewModel = _componentContext.Resolve<TviewModel>(parameter);
            var viewType = _map[typeof(TviewModel)];
            var view = _componentContext.Resolve(viewType) as Page;

            view.BindingContext = viewModel;
            return view;
        }

        public Page ResolveWithParameters<TviewModel>(params Parameter[] parameters) where TviewModel : class, IViewModel
        {
            if (parameters.Length == 0) throw new ArgumentNullException();
            if (parameters == null) throw new ArgumentNullException();

            TviewModel viewModel = _componentContext.Resolve<TviewModel>(parameters);
            var viewType = _map[typeof(TviewModel)];
            var view = _componentContext.Resolve(viewType) as Page;

            view.BindingContext = viewModel;
            return view;
        }
    }
}
