using DevExpress.XtraReports.UI;
using Microsoft.Extensions.DependencyInjection;

namespace PlatigeImage.Factory.ReportFactory
{
    public class ReportFactory(IServiceProvider serviceProvider) : IReportFactory
    {
        private readonly IServiceProvider _serviceProvider = serviceProvider;

        public XtraReport CreateReport<TReport, TData>(TData data) where TReport : XtraReport
        {
            return (XtraReport)ActivatorUtilities.CreateInstance(_serviceProvider, typeof(TReport), data);
        }     
    }
}
