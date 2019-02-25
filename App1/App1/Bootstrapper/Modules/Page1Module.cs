using System;
using System.Collections.Generic;
using System.Text;
using App1.ViewModels;
using App1.Views;
using Autofac;

namespace Autofac_IoC.Bootstrapper.Modules
{
    class Page1Module : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Page1>().SingleInstance();
            builder.RegisterType<Page1ViewModel>().SingleInstance();
        }
    }
}
