using PlatigeImage.Data.Entities;
using PlatigeImage.Enums;
using PlatigeImage.Factory.GenerateData;
using PlatigeImage.Factory.ImageComboBoxDataLoaderFactory;
using PlatigeImage.Infrastructure.DataAccess.Contractors;

namespace PlatigeImage.Forms
{
    public partial class ContractorForm : BaseForm
    {
        private readonly IContractorRepository _contractorRepository;

        public ContractorForm(IContractorRepository contractorRepository, IImageComboBoxDataLoaderFactory imageComboBoxDataLoaderFactory, IGenerateDataFactory generateDataFactory)
            : base(imageComboBoxDataLoaderFactory, generateDataFactory)
        {
            InitializeComponent();
            _contractorRepository = contractorRepository;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FillType();
            bsContractor.DataSource = _contractorRepository.GetDataToBindingSource();
        }

        private async void FillType()
        {
            var data = ImageComboBoxDataLoaderFactory.Create(FillImageComboBoxEnum.ContractorType);
            await data.LoadDataAsync(riiceType.Items);
        }

        protected override async void OnConfirm()
        {
            await _contractorRepository.SaveAsync();
        }

        protected async override void GenerateData()
        {
            var strategy = GenerateDataFactory.Create<Contractor>();
            var contractors = await strategy.GenerateData(InputValue);
            if (contractors == null)
                return;

            foreach (var contractor in contractors)
                bsContractor.Add(contractor);
        }
    }
}
