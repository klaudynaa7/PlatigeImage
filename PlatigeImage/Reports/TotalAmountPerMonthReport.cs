using DevExpress.XtraReports.UI;
using PlatigeImage.Dto.TotalAmountPerMonth;

namespace PlatigeImage.Reports
{
    public partial class TotalAmountPerMonthReport : DevExpress.XtraReports.UI.XtraReport
    {
        public TotalAmountPerMonthReport(List<MonthlyInvoiceSummaryDto> monthlyInvoiceSummary)
        {
            InitializeComponent();

            foreach (var monthInvoiceSummary in monthlyInvoiceSummary)
            {
                XRTableRow row = new XRTableRow();
                XRTableCell cell1 = new XRTableCell();
                XRTableCell cell2 = new XRTableCell();
                XRTableCell cell3 = new XRTableCell();

                cell1.Text = monthInvoiceSummary.Month.ToString();
                cell2.Text = monthInvoiceSummary.TotalNetAmount.ToString();
                cell3.Text = monthInvoiceSummary.TotalGrossAmount.ToString();

                row.Cells.AddRange([cell1, cell2, cell3]);
                xtrMonthlyTotalAmount.Rows.Add(row);
            }
        }
    }
}
