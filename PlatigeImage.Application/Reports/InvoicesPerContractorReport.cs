using DevExpress.XtraReports.UI;
using PlatigeImage.Dto.InvoicesPerContractor;

namespace PlatigeImage.Reports
{
    public partial class InvoicesPerContractorReport : XtraReport
    {
        public InvoicesPerContractorReport(List<MonthlyInvoiceSummary> contractorReports)
        {
            InitializeComponent();

            foreach (var contractor in contractorReports)
            {
                XRTableRow row = new XRTableRow();
                XRTableCell cell1 = new XRTableCell();
                XRTableCell cell2 = new XRTableCell();

                cell1.Text = contractor.ContractorName.ToString();
                cell2.Text = contractor.Country;

                row.Cells.AddRange([cell1, cell2]);
                xtInvoices.Rows.Add(row);
            }
        }
    }
}
