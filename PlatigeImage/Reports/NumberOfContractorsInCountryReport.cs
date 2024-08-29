using DevExpress.XtraReports.UI;
using PlatigeImage.Dto.NumberOfContractorsInCountryReport;

namespace PlatigeImage.Reports
{
    public partial class NumberOfContractorsInCountryReport : XtraReport
    {
        public NumberOfContractorsInCountryReport(List<CountryContractorCountDto> contractors)
        {
            InitializeComponent();
            DataSource = contractors;
        }
    }
}
