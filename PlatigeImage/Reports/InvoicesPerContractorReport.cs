using DevExpress.XtraReports.UI;
using PlatigeImage.Dto.InvoicesPerContractor;

namespace PlatigeImage.Reports
{
    public partial class InvoicesPerContractorReport : XtraReport
    {
        public InvoicesPerContractorReport(List<InvoicesPerContractorDto> contractorReports)
        {
            InitializeComponent();

            DataSource = contractorReports;
        }
    }
}
