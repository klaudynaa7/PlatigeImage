using DevExpress.XtraReports.UI;

namespace PlatigeImage.Factory.ReportFactory
{
    public interface IReportFactory
    {
        XtraReport CreateReport<TReport, TData>(TData data) where TReport : XtraReport;
    }
}
