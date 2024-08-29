using DevExpress.XtraEditors.Controls;
using PlatigeImage.Infrastructure.DataAccess.Contractors;

namespace PlatigeImage.FillImageComboBox
{
    public class ContractorImageComboBoxDataLoader(IContractorRepository contractorRepository) : IImageComboBoxDataLoader
    {
        private readonly IContractorRepository _contractorRepository = contractorRepository;

        public async Task LoadDataAsync(ImageComboBoxItemCollection items)
        {
            items.Clear();

            var contractors = await _contractorRepository.GetListOfAllAsync();
            foreach (var contractor in contractors)
            {
                items.Add(new ImageComboBoxItem(contractor.Name, contractor.Id, -1));
            }
        }
    }
}
