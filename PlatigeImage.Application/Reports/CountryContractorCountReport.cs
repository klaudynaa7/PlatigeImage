using DevExpress.XtraReports.UI;
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
                XRTableRow row = new();
                XRTableCell cell1 = new();
                XRTableCell cell2 = new();

                cell1.Text = contractor.ContractorCount.ToString();
                cell2.Text = contractor.Country;                

                row.Cells.AddRange([cell1, cell2]);
                xtCountryContractorCount.Rows.Add(row);
            }
        }
    }
}
