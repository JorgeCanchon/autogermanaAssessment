using AutogermanaTest.Core.Interfaces.Repositories;
using AutogermanaTest.Infraestructure.Data.EntityFrameworkSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AutogermanaTest.Infraestructure.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection service)
        {
            service.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        public static void ConfigureMySqlServerDBContext(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<RepositoryContextSqlServer>(
                    options => options.UseSqlServer(configuration.GetConnectionString("SqlServerDBContext"), npgsqlOptions => {
                        npgsqlOptions.CommandTimeout(60);
                    }),
                    ServiceLifetime.Transient
                );
        }

    }
}
