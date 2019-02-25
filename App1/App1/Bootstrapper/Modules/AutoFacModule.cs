using System;
using System.Collections.Generic;
using System.Text;
using App1;
using Autofac;
using Autofac_IoC.Factory;
using Autofac_IoC.Services;
using Xamarin.Forms;

namespace Autofac_IoC.Bootstrapper.Modules
{
    class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ViewFactory>().As<IViewFactory>().SingleInstance();
            builder.RegisterType<Navigator>().As<INavigator>().SingleInstance();
            builder.Register<INavigation>(context => App.Current.MainPage.Navigation).SingleInstance();
        }
    }
}
