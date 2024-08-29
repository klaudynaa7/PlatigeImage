using PlatigeImage.Data.Entities;
using PlatigeImage.Enums;
using PlatigeImage.Factory.GenerateData;
using PlatigeImage.Factory.ImageComboBoxDataLoaderFactory;
using PlatigeImage.Infrastructure.DataAccess.Invoices;

namespace PlatigeImage.Forms
{
    public partial class InvoiceForm : BaseForm
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceForm(IInvoiceRepository invoiceRepository, IImageComboBoxDataLoaderFactory imageComboBoxDataLoaderFactory, IGenerateDataFactory generateDataFactory) 
            : base(imageComboBoxDataLoaderFactory, generateDataFactory)
        {
            InitializeComponent();
            _invoiceRepository = invoiceRepository;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FillContractor();
            bsInvoice.DataSource = _invoiceRepository.GetDataToBindingSource();
        }

        private async void FillContractor()
        {
            var data = ImageComboBoxDataLoaderFactory.Create(FillImageComboBoxEnum.Contractor);
            await data.LoadDataAsync(riiceContractor.Items);
        }

        protected async override void OnConfirm()
        {
            await _invoiceRepository.SaveAsync();
        }

        protected async override void GenerateData()
        {
            var strategy = GenerateDataFactory.Create<Invoice>();
            var invoices = await strategy.GenerateData(InputValue);
            if (invoices == null)
                return;

            foreach (var contractor in invoices)
                bsInvoice.Add(contractor);
        }
    }
}
