using PlatigeImage.Data.Entities;
using System.ComponentModel;
using System.Linq.Expressions;

namespace PlatigeImage.Infrastructure.DataAccess.Base
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAllAsync();

        Task<IList<TEntity>> GetListOfAllAsync();
        Task SaveAsync();
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);        
    }
}
