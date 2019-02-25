using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Autofac_IoC.Bootstrapper.Modules;
using Autofac_IoC.Factory;

namespace Autofac_IoC.Bootstrapper
{
    public abstract class AutofacBootstrapper
    {
        private Dictionary<Type, Type> _mappedTypes;

        protected abstract void RegisterViews(IViewFactory viewFactory);
        protected abstract void ConfigureApplication(IContainer container);

        public void RunWithMappedTypes(Dictionary<Type, Type> mappedTypes)
        {
            _mappedTypes = mappedTypes;

            var builder = new ContainerBuilder();

            this.ConfigureContainer(builder);

            var container = builder.Build();

            var viewFactory = container.Resolve<IViewFactory>();

            RegisterViews(viewFactory);
            ConfigureApplication(container);
        }

        protected virtual void ConfigureContainer(ContainerBuilder builder)
        {
            if (_mappedTypes != null && _mappedTypes.Any())
            {
                builder.RegisterModule(new MappedTypesModule(_mappedTypes));
            }

            builder.RegisterModule<ServiceModule>();
            builder.RegisterModule<AutoFacModule>();
        }
    }
}
