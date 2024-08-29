using PlatigeImage.Enums;
using PlatigeImage.FillImageComboBox;

namespace PlatigeImage.Factory.ImageComboBoxDataLoaderFactory
{
    public interface IImageComboBoxDataLoaderFactory
    {
        IImageComboBoxDataLoader Create(FillImageComboBoxEnum enums);
    }
}
