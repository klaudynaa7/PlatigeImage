using DevExpress.XtraEditors.Controls;

namespace PlatigeImage.FillImageComboBox
{
    public interface IImageComboBoxDataLoader
    {
        Task LoadDataAsync(ImageComboBoxItemCollection items);
    }
}
