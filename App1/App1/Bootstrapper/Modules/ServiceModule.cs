using System;
using System.Collections.Generic;
using System.Text;
using App1.Services;
using Autofac;

namespace Autofac_IoC.Bootstrapper.Modules
{
    class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PageService>().As<IPageService>().SingleInstance();
        }
    }
}
