using DevExpress.XtraReports.UI;
using PlatigeImage.Dto.TotalAmountPerMonth;

namespace PlatigeImage.Reports
{
    public partial class TotalAmountPerMonthReport : XtraReport
    {
        public TotalAmountPerMonthReport(List<MonthlyInvoiceSummaryDto> monthlyInvoiceSummary)
        {
            InitializeComponent();
            DataSource = monthlyInvoiceSummary;
        }
    }
}
