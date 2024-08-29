using PlatigeImage.Data.Entities;
using PlatigeImage.GenerateData;

namespace PlatigeImage.Factory.GenerateData
{
    public interface IGenerateDataFactory
    {
        IGenerateData<T> Create<T>() where T : BaseEntity;
    }
}
