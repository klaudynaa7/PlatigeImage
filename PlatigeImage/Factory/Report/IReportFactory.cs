using DevExpress.XtraReports.UI;
using PlatigeImage.Enums;

namespace PlatigeImage.Factory.ReportFactory
{
    public interface IReportFactory
    {
        XtraReport CreateReport<TData>(TypeOfReportEnum type, TData data);
    }
}
