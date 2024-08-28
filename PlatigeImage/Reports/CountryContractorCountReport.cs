using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using PlatigeImage.Dto.NumberOfContractorsInCountryReport;

namespace PlatigeImage.Reports
{
    public partial class NumberOfContractorsInCountryReport : XtraReport
    {
        public NumberOfContractorsInCountryReport(List<CountryContractorCountDto> contractors)
        {
            InitializeComponent();

            foreach (var contractor in contractors)
            {
                XRTableRow row = new XRTableRow();
                XRTableCell cell1 = new XRTableCell();
                XRTableCell cell2 = new XRTableCell();

                cell1.Text = contractor.ContractorCount.ToString();
                cell2.Text = contractor.Country;                

                row.Cells.AddRange([cell1, cell2]);
                xtCountryContractorCount.Rows.Add(row);
            }
        }
    }
}
