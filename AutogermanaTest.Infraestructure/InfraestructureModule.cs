using Autofac;
using AutogermanaTest.Core.Interfaces.Repositories;
using AutogermanaTest.Infraestructure.Data.EntityFrameworkSQL;

namespace AutogermanaTest.Infraestructure
{
    public class InfraestructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RepositoryWrapper>().As<IRepositoryWrapper>().InstancePerLifetimeScope();
        }
    }
}
