using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UI;
using PlatigeImage.Dto.InvoicesPerContractor;
using PlatigeImage.Dto.NumberOfContractorsInCountryReport;
using PlatigeImage.Dto.TotalAmountPerMonth;
using PlatigeImage.Factory.FormFactory;
using PlatigeImage.Factory.ReportFactory;
using PlatigeImage.Forms;
using PlatigeImage.Infrastructure.DataAccess.Contractors;
using PlatigeImage.Infrastructure.DataAccess.Invoices;
using PlatigeImage.Reports;

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

        private void OpenReport<TReport, TData>(TData data) where TReport : XtraReport
        {
            var reportInstance = _reportFactory.CreateReport<TReport, TData>(data);
            reportInstance.ShowPreview();
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
            OpenReport<InvoicesPerContractorReport, IList<InvoicesPerContractorDto>>(contractorReports);
        }

        private async void bbiTotalValueOfInvoicePerMonthReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            var totalAmountPerMonth = await GetTotalAmountPerMonth();
            OpenReport<TotalAmountPerMonthReport, IList<MonthlyInvoiceSummaryDto>>(totalAmountPerMonth);
        }

        private async void bbiNumberOfContractorsInCountry_ItemClick(object sender, ItemClickEventArgs e)
        {
            var numberOfContractorsInCountry = await GetNumberOfContractorsInCountry();
            OpenReport<NumberOfContractorsInCountryReport, IList<CountryContractorCountDto>>(numberOfContractorsInCountry);
        }

        private async Task<IList<InvoicesPerContractorDto>> GetInvoicesPerContractor()
        {
            return await _invoiceRepository.GetInvoicesPerContractorAsync();

        }

        private async Task<IList<MonthlyInvoiceSummaryDto>> GetTotalAmountPerMonth()
        {
            return await _invoiceRepository.GetTotalAmountPerMonth();
        }

        private async Task<IList<CountryContractorCountDto>> GetNumberOfContractorsInCountry()
        {
            return await _contractorRepository.GetNumberOfContractorsInCountryAsync();
        }        
        #endregion
    }
}