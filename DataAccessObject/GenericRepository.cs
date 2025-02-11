using BusinessObject;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessObject
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : BaseEntity
    {
        protected DbSet<TModel> _dbSet;

        public GenericRepository(DbContext dbContext)
        {
            _dbSet = dbContext.Set<TModel>();
        }

        public async Task AddAsync(TModel model)
        {
            await _dbSet.AddAsync(model);
        }

        public void Delete(TModel model)
        {
            _dbSet.Remove(model);
        }

        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TModel> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task SoftDeleteAsync(TModel model)
        {
            model.IsDeleted = true;
        }

        public void Update(TModel model)
        {
            _dbSet.Update(model);
        }
    }
}
