using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UI;
using PlatigeImage.Dto.InvoicesPerContractor;
using PlatigeImage.Dto.NumberOfContractorsInCountryReport;
using PlatigeImage.Dto.TotalAmountPerMonth;
using PlatigeImage.Enums;
using PlatigeImage.Factory.FormFactory;
using PlatigeImage.Factory.ReportFactory;
using PlatigeImage.Forms;
using PlatigeImage.Infrastructure.DataAccess.Contractors;
using PlatigeImage.Infrastructure.DataAccess.Invoices;

namespace PlatigeImage
{
    public partial class MainForm : RibbonForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IFormFactory _formFactory;
        private readonly IReportFactory _reportFactory;

        private readonly IContractorRepository _contractorRepository;
        private readonly IInvoiceRepository _invoiceRepository;

        public MainForm(IServiceProvider serviceProvider, IFormFactory formFactory, IReportFactory reportFactory, IContractorRepository contractorRepository, IInvoiceRepository invoiceRepository)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _formFactory = formFactory;
            _reportFactory = reportFactory;
            _contractorRepository = contractorRepository;
            _invoiceRepository = invoiceRepository;
            IsMdiContainer = true;
        }

        private void OpenForm<T>() where T : BaseForm
        {
            var childForm = _formFactory.Create<T>();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void OpenReport<TData>(TypeOfReportEnum reportType, TData data)
        {
            var report = _reportFactory.CreateReport(reportType, data);
            report.ShowPreview();
        }

        #region Form
        private void bbiContractor_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<ContractorForm>();
        }

        private void btnInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<InvoiceForm>();
        }
        #endregion

        #region Report
        private async void bbiInvoicesPerContractorReports_ItemClickAsync(object sender, ItemClickEventArgs e)
        {
            var contractorReports = await GetInvoicesPerContractor();
            OpenReport(TypeOfReportEnum.InvoicesPerContractorReport, contractorReports);
        }

        private async void bbiTotalValueOfInvoicePerMonthReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            var contractorCountsByCountry = await GetTotalAmountPerMonth();
            OpenReport(TypeOfReportEnum.TotalAmountPerMonthReport, contractorCountsByCountry);
        }

        private async void bbiNumberOfContractorsInCountry_ItemClick(object sender, ItemClickEventArgs e)
        {
            var numberOfContractorsInCountry = await GetNumberOfContractorsInCountry();
            OpenReport(TypeOfReportEnum.NumberOfContractorsInCountryReport, numberOfContractorsInCountry);
        }

        private async Task<List<CountryContractorCountDto>> GetNumberOfContractorsInCountry()
        {
            return await _contractorRepository.GetNumberOfContractorsInCountryAsync();
        }

        private async Task<List<MonthlyInvoiceSummary>> GetInvoicesPerContractor()
        {
            return await _contractorRepository.GetInvoicesPerContractorAsync();

        }

        private async Task<IList<MonthlyInvoiceSummaryDto>> GetTotalAmountPerMonth()
        {
            return await _invoiceRepository.GetTotalAmountPerMonth();
        }
        #endregion
    }
}