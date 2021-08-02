using System.Collections.Generic;
using Autofac;

namespace SomeApp
{
    public class Feature1 : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<Dictionary<string, object>>().As<IDictionary<string, object>>();
        }
    }
}