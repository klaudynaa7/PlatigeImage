using DevExpress.XtraReports.UI;
using Microsoft.Extensions.DependencyInjection;
using PlatigeImage.Enums;
using PlatigeImage.Reports;

namespace PlatigeImage.Factory.ReportFactory
{
    public class ReportFactory(IServiceProvider serviceProvider) : IReportFactory
    {
        private readonly IServiceProvider _serviceProvider = serviceProvider;

        public XtraReport CreateReport<TData>(TypeOfReportEnum type, TData data)
        {
            var reportType = GetReportType(type);
            var report = (XtraReport)ActivatorUtilities.CreateInstance(_serviceProvider, reportType, data);
            return report;
        }

        public XtraReport CreateReport(TypeOfReportEnum type)
        {
            var reportType = GetReportType(type);
            var report = (XtraReport)ActivatorUtilities.CreateInstance(_serviceProvider, reportType);
            return report;
        }

        private Type GetReportType(TypeOfReportEnum type)
        {
            return type switch
            {
                TypeOfReportEnum.NumberOfContractorsInCountryReport => typeof(NumberOfContractorsInCountryReport),
                TypeOfReportEnum.InvoicesPerContractorReport => typeof(InvoicesPerContractorReport),
                TypeOfReportEnum.TotalAmountPerMonthReport => typeof(TotalAmountPerMonthReport),
                _ => throw new ArgumentException(),
            };
        }        
    }
}
