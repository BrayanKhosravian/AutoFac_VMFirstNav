using System;
using System.Collections.Generic;
using System.Text;
using App1.ViewModels;
using App1.Views;
using Autofac;

namespace Autofac_VMFirstNav.Bootstrapper.Modules
{
    class Page3Module : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Page3>().SingleInstance();
            builder.RegisterType<Page3ViewModel>().SingleInstance();
        }
    }
}
