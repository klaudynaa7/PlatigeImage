using PlatigeImage.Data.Entities;

namespace PlatigeImage.GenerateData
{
    public interface IGenerateData<T> where T : BaseEntity
    {
        Task<List<T>?> GenerateData(int inputValue);
    }
}
