using argusTech.DataAccess.Concrete.EntityFrameworkCore.Context;
using argusTech.DataAccess.Interfaces;
using argusTech.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace argusTech.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            var context = new ArgusTechContext();
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            var context = new ArgusTechContext();
            return await context.FindAsync<TEntity>(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            var context = new ArgusTechContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            var context = new ArgusTechContext();
            return await context.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            var context = new ArgusTechContext();
            return await context.Set<TEntity>().Where(filter).OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            var context = new ArgusTechContext();
            return await context.Set<TEntity>().OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            var context = new ArgusTechContext();
            return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task RemoveAsync(TEntity entity)
        {
            var context = new ArgusTechContext();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            var context = new ArgusTechContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
