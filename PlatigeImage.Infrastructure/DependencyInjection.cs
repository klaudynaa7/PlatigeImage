using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlatigeImage.Data;
using PlatigeImage.Infrastructure.Connection;
using PlatigeImage.Infrastructure.DataAccess.Contractors;
using PlatigeImage.Infrastructure.DataAccess.Invoices;

namespace PlatigeImage.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<DatabaseConfig>();
            services.AddDbContext<ApplicationDbContext>((services, options) =>
            {
                var dbConfig = services.GetRequiredService<DatabaseConfig>();
                options.UseSqlServer(dbConfig.GetConnectionString());
            }, ServiceLifetime.Transient);

            services.AddRepositories();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IContractorRepository, ContractorRepository>();
            services.AddTransient<IInvoiceRepository, InvoiceRepository>();
        }
    }
}
