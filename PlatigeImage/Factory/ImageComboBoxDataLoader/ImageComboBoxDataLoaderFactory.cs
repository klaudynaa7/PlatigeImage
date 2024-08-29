using PlatigeImage.FillImageComboBox;
using PlatigeImage.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace PlatigeImage.Factory.ImageComboBoxDataLoaderFactory
{
    public class ImageComboBoxDataLoaderFactory(IServiceProvider serviceProvider) : IImageComboBoxDataLoaderFactory
    {
        private readonly IServiceProvider _serviceProvider = serviceProvider;

        public IImageComboBoxDataLoader Create(FillImageComboBoxEnum fillImageComboBox)
        {
            return fillImageComboBox switch
            {
                FillImageComboBoxEnum.ContractorType => _serviceProvider.GetRequiredService<ContractorTypeImageComboBoxDataLoader>(),
                FillImageComboBoxEnum.Contractor => _serviceProvider.GetRequiredService<ContractorImageComboBoxDataLoader>(),
                _ => throw new ArgumentException()
            };
        }
    }
}
