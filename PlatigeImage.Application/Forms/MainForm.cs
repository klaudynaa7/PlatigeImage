using DevExpress.Diagram.Core.Native;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UI;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.Data;
using PlatigeImage.Dto.InvoicesPerContractor;
using PlatigeImage.Dto.NumberOfContractorsInCountryReport;
using PlatigeImage.Dto.TotalAmountPerMonth;
using PlatigeImage.Factory.FormFactory;
using PlatigeImage.Forms;
using PlatigeImage.Reports;

namespace PlatigeImage
{
    public partial class MainForm : RibbonForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ApplicationDbContext _dbContext;
        private readonly IFormFactory _formFactory;

        public MainForm(IServiceProvider serviceProvider, ApplicationDbContext dbContext, IFormFactory formFactory)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _dbContext = dbContext;
            _formFactory = formFactory;
            IsMdiContainer = true;
        }

        private void OpenForm<T>() where T : BaseForm
        {
            var childForm = _formFactory.Create<T>();
            childForm.MdiParent = this;
            childForm.Show();
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

            var report = new InvoicesPerContractorReport(contractorReports);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();

        }

        private async void bbiTotalValueOfInvoicePerMonthReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            var contractorCountsByCountry = await GetTotalAmountPerMonth();

            var report = new TotalAmountPerMonthReport(contractorCountsByCountry);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }

        private async void bbiNumberOfContractorsInCountry_ItemClick(object sender, ItemClickEventArgs e)
        {
            var contractorCountsByCountry = await GetNumberOfContractorsInCountry();

            var report = new NumberOfContractorsInCountryReport(contractorCountsByCountry);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();

        }

        private async Task<List<CountryContractorCountDto>> GetNumberOfContractorsInCountry()
        {
            var contractorCountsByCountry = await _dbContext.Contractors
                .GroupBy(c => c.Country)
                .Select(g => new CountryContractorCountDto
                {
                    ContractorCount = g.Count(),
                    Country = g.Key
                })
                .ToListAsync();

            return contractorCountsByCountry;

        }

        private async Task<List<MonthlyInvoiceSummary>> GetInvoicesPerContractor()
        {
            var contractorReports = await _dbContext.Contractors
                .Include(c => c.Invoices)
                .Select(c => new MonthlyInvoiceSummary
                {
                    ContractorId = c.Id,
                    ContractorName = c.Name,
                    Country = c.Country,
                    Invoices = c.Invoices.Select(i => new InvoiceInfoDto
                    {
                        InvoiceId = i.Id,
                        NetAmount = i.NetValues,
                        GrossAmount = i.GrossValue
                    }).ToList(),
                    TotalNetAmount = c.Invoices.Sum(i => i.NetValues),
                    TotalGrossAmount = c.Invoices.Sum(i => i.GrossValue)
                })
                .ToListAsync();

            return contractorReports;

        }

        private async Task<List<MonthlyInvoiceSummaryDto>> GetTotalAmountPerMonth()
        {
            var monthlySummaries = await _dbContext.Invoices
                .GroupBy(i => new { i.SaleDate.Year, i.SaleDate.Month })
                .Select(g => new MonthlyInvoiceSummaryDto
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    TotalNetAmount = g.Sum(i => i.NetValues),
                    TotalGrossAmount = g.Sum(i => i.GrossValue)
                })
                .OrderBy(s => s.Year)
                .ThenBy(s => s.Month)
                .ToListAsync();

            return monthlySummaries;

        }
        #endregion
    }
}