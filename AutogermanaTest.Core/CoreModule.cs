using Autofac;
using AutogermanaTest.Core.Interfaces.UsesCases;
using AutogermanaTest.Core.UsesCases;

namespace AutogermanaTest.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductInteractor>().As<IProductInteractor>().InstancePerLifetimeScope();
        }
    }
}
