using DevExpress.XtraEditors.Controls;
using PlatigeImage.Enums;

namespace PlatigeImage.FillImageComboBox
{
    public class ContractorTypeImageComboBoxDataLoader : IImageComboBoxDataLoader
    {
        private const string _comapany = "Firma";
        private const string _individual = "Osoba prywatna";

        public Task LoadDataAsync(ImageComboBoxItemCollection items)
        {
            items.Clear();
            items.Add(new ImageComboBoxItem(_comapany, Convert.ToByte(ContractorTypeEnum.Company), -1));
            items.Add(new ImageComboBoxItem(_individual, Convert.ToByte(ContractorTypeEnum.Individual), -1));
            return Task.CompletedTask;
        }
    }
}
