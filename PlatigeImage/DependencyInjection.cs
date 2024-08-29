using Microsoft.Extensions.DependencyInjection;
using PlatigeImage.Factory.FormFactory;
using PlatigeImage.Factory.GenerateData;
using PlatigeImage.Factory.ImageComboBoxDataLoaderFactory;
using PlatigeImage.Factory.ReportFactory;
using PlatigeImage.FillImageComboBox;
using PlatigeImage.Forms;
using PlatigeImage.GenerateData;
using PlatigeImage.Reports;

namespace PlatigeImage
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<IFormFactory, FormFactory>();
            services.AddSingleton<IReportFactory, ReportFactory>();
            services.AddSingleton<IImageComboBoxDataLoaderFactory, ImageComboBoxDataLoaderFactory>();
            services.AddSingleton<IGenerateDataFactory, GenerateDataFactory>();
            AddForms(services);
            return services;
        }
        public static IServiceCollection AddForms(this IServiceCollection services)
        {
            services.AddTransient<DatabaseConnectionForm>();
            services.AddTransient<MainForm>();
            services.AddTransient<BaseForm>();
            services.AddTransient<ContractorForm>();
            services.AddTransient<InvoiceForm>();

            services.AddTransient<NumberOfContractorsInCountryReport>();
            services.AddTransient<InvoicesPerContractorReport>();
            services.AddTransient<TotalAmountPerMonthReport>();

            services.AddTransient<ContractorImageComboBoxDataLoader>();
            services.AddTransient<ContractorTypeImageComboBoxDataLoader>();
            
            return services;
        }
    }
}