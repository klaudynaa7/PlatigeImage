using Microsoft.EntityFrameworkCore;
using PlatigeImage.Data;
using PlatigeImage.Data.Entities;
using System.Linq.Expressions;

namespace PlatigeImage.Infrastructure.DataAccess.Base
{
    public abstract class BaseRepository<TEntity>(ApplicationDbContext dbContext) : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext = dbContext;
        protected ApplicationDbContext DbContext => _dbContext;

        public IQueryable<TEntity> GetAllAsync()        
            => _dbContext.Set<TEntity>();

        public async Task<IList<TEntity>> GetListOfAllAsync()
            => await GetAllAsync().ToListAsync();
        

        public async Task SaveAsync()
            => await _dbContext.SaveChangesAsync();
        

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
            => await GetAllAsync().AnyAsync(predicate);
    }
}
