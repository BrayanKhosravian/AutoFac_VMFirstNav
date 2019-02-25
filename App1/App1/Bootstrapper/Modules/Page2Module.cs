using System;
using System.Collections.Generic;
using System.Text;
using App1.ViewModels;
using App1.Views;
using Autofac;

namespace Autofac_IoC.Bootstrapper.Modules
{
    class Page2Module : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Page2>().SingleInstance();
            builder.RegisterType<Page2ViewModel>().SingleInstance();
        }
    }
}
