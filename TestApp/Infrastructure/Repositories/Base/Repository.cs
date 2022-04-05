using Core.Repositories.Base;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly CheeseContext _cheeseContext;

        public Repository(CheeseContext cheeseContext)
        {
            _cheeseContext = cheeseContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _cheeseContext.Set<T>().AddAsync(entity);
            await _cheeseContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _cheeseContext.Set<T>().Remove(entity);
            await _cheeseContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _cheeseContext.Set<T>().ToListAsync();

        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _cheeseContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity, int id)
        {
            var temp = await _cheeseContext.Set<T>().FindAsync(id);
            temp = entity;
            await _cheeseContext.SaveChangesAsync();

        }

       
    }
}
         
