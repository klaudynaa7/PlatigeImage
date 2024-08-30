using Microsoft.EntityFrameworkCore;
using PlatigeImage.Data;
using PlatigeImage.Data.Entities;
using System.ComponentModel;

namespace PlatigeImage.Infrastructure.DataAccess.Base
{
    public abstract class BaseRepository<TEntity>(ApplicationDbContext dbContext) : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext = dbContext;
        protected ApplicationDbContext DbContext => _dbContext;
        public BindingList<TEntity> GetDataToBindingSource()
        {
            _dbContext.Set<TEntity>().Load();
            return _dbContext.Set<TEntity>().Local.ToBindingList();
        }

        public IQueryable<TEntity> GetAll()        
            => _dbContext.Set<TEntity>();

        public async Task<IList<TEntity>> GetListOfAllAsync()
            => await GetAll().ToListAsync();
        

        public async Task SaveAsync()
            => await _dbContext.SaveChangesAsync();
        

        public async Task<bool> AnyAsync()
            => await GetAll().AnyAsync();
    }
}