using PlatigeImage.Data.Entities;
using System.ComponentModel;

namespace PlatigeImage.Infrastructure.DataAccess.Base
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        BindingList<TEntity> GetDataToBindingSource();
        IQueryable<TEntity> GetAll();
        Task<IList<TEntity>> GetListOfAllAsync();
        Task SaveAsync();
        Task<bool> AnyAsync();        
    }
}
