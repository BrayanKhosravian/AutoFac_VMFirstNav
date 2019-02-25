using System;
using System.Collections.Generic;
using System.Text;
using App1;
using App1.ViewModels;
using App1.Views;
using Autofac;
using Autofac_IoC.Bootstrapper.Modules;
using Autofac_IoC.Factory;
using Autofac_VMFirstNav.Bootstrapper.Modules;
using Xamarin.Forms;

namespace Autofac_IoC.Bootstrapper
{
    class Bootstrapper : AutofacBootstrapper
    {
        private readonly App _app;

        public Bootstrapper(App app)
        {
            _app = app;
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);
            builder.RegisterModule<Page1Module>();
            builder.RegisterModule<Page2Module>();
            builder.RegisterModule<Page3Module>();

        }

        protected override void RegisterViews(IViewFactory viewFactory)
        {
            viewFactory.Register<Page1ViewModel, Page1>();
            viewFactory.Register<Page2ViewModel, Page2>();
            viewFactory.Register<Page3ViewModel, Page3>();
        }

        protected override void ConfigureApplication(IContainer container)
        {
            var viewFactory = container.Resolve<IViewFactory>();
            var mainPage = viewFactory.Resolve<Page1ViewModel>();
            var navigationPage = new NavigationPage(mainPage);
            _app.MainPage = navigationPage;
        }
    }
}
