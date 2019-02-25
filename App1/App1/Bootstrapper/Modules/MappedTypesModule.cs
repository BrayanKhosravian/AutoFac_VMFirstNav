using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Autofac_IoC.Bootstrapper.Modules
{
    class MappedTypesModule : Module
    {
        private readonly Dictionary<Type, Type> _mappedTypes;

        public MappedTypesModule(Dictionary<Type, Type> mappedTypes)
        {
            _mappedTypes = mappedTypes;
        }

        protected override void Load(ContainerBuilder builder)
        {
            foreach (var kvp in _mappedTypes)
            {
                builder.RegisterType(kvp.Key).As(kvp.Value);
            }
        }
    }
}
