using BSU_Teachers.DataAccessLayer.Repositories.Interfaces;
using BSU_Teachers.DataLayer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.DataAccessLayer.Repositories.Implementations
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
       
        public DbContext _context { get; private set; }

        public TEntity Context { get => _context as TEntity;  }

        public Repository(DbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<int> Update(TEntity item)
        {
            _context.Set<TEntity>().Update(item);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Add(TEntity item)
        {
            await _context.Set<TEntity>().AddAsync(item);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Detete(int id)
        {
            var itemToDelete = new TEntity
            {
                Id = id
            };

            _context.Set<TEntity>().Remove(itemToDelete);

            return await _context.SaveChangesAsync();
        }
    }
}
