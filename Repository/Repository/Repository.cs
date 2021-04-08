using Entities.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    // https://devdarianigeo.atlassian.net/browse/RG-10
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        // https://devdarianigeo.atlassian.net/browse/RG-17
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(TEntity)} entity must not be null");
            }

            try
            {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        // https://devdarianigeo.atlassian.net/browse/RG-18
        public async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        // https://devdarianigeo.atlassian.net/browse/RG-19
        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return  _context.Set<TEntity>().AsNoTracking();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        // https://devdarianigeo.atlassian.net/browse/RG-20
        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            
            return await _context.Set<TEntity>()
                  .AsNoTracking()
                  .FirstOrDefaultAsync(e => e.Id == id);
        }

        // https://devdarianigeo.atlassian.net/browse/RG-21
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(TEntity)} entity must not be null");
            }

            try
            {
                _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
    }
}
