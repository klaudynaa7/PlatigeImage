using DevExpress.XtraReports.UI;
using PlatigeImage.Dto.TotalAmountPerMonth;
using System.Globalization;

namespace PlatigeImage.Reports
{
    public partial class TotalAmountPerMonthReport : XtraReport
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

                cell1.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthInvoiceSummary.Month); //monthInvoiceSummary.Month.ToString(); //.ToString("MMMM", CultureInfo.InvariantCulture); ; //monthInvoiceSummary.Month.ToString();
                cell2.Text = monthInvoiceSummary.TotalNetAmount.ToString();
                cell3.Text = monthInvoiceSummary.TotalGrossAmount.ToString();

                row.Cells.AddRange([cell1, cell2, cell3]);
                xtrMonthlyTotalAmount.Rows.Add(row);
            }
        }
    }
}
