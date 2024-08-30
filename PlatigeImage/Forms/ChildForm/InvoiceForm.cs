using PlatigeImage.Data.Entities;
using PlatigeImage.Enums;
using PlatigeImage.Factory.GenerateData;
using PlatigeImage.Factory.ImageComboBoxDataLoaderFactory;
using PlatigeImage.Infrastructure.DataAccess.Contractors;
using PlatigeImage.Infrastructure.DataAccess.Invoices;
using PlatigeImage.Resources;

namespace PlatigeImage.Forms
{
    public partial class InvoiceForm : BaseForm
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IContractorRepository _contractorRepository;

        public InvoiceForm(
            IInvoiceRepository invoiceRepository,
            IContractorRepository contractorRepository,
            IImageComboBoxDataLoaderFactory imageComboBoxDataLoaderFactory, 
            IGenerateDataFactory generateDataFactory) 
            : base(imageComboBoxDataLoaderFactory, generateDataFactory)
        {
            InitializeComponent();
            _invoiceRepository = invoiceRepository;
            _contractorRepository = contractorRepository;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FillContractor();
            bsInvoice.DataSource = _invoiceRepository.GetDataToBindingSource();
        }

        private async void FillContractor()
        {
            if (DesignMode)
                return;

            var data = ImageComboBoxDataLoaderFactory.Create(FillImageComboBoxEnum.Contractor);
            await data.LoadDataAsync(riiceContractor.Items);
        }

        protected async override void OnConfirm()
        {
            await _invoiceRepository.SaveAsync();
        }

        protected async override void GenerateData()
        {
            if(! await CheckAnyContractorExists())
                return;

            var strategy = GenerateDataFactory.Create<Invoice>();
            var invoices = await strategy.GenerateData(InputValue);
            if (invoices == null)
                return;

            foreach (var contractor in invoices)
                bsInvoice.Add(contractor);
        }

        private async Task<bool> CheckAnyContractorExists()
        {
            if (!await _contractorRepository.AnyAsync())
            {
                MessageBox.Show(StringResource.NoContractorExistsInvoicesCannotBeGenerated);
                return false;
            }
            return true;
        }
    }
}
