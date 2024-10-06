using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Managment.Application.Contracts.Persistence.Common;
using Microsoft.EntityFrameworkCore;

namespace HR_Managment.Persistance.Repositories
{
    public class GenericRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private LeaveManagmentDbContext _context;

        public GenericRepository(LeaveManagmentDbContext context)
        {
            _context = context;
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
          await  _context.SaveChangesAsync();
        }

        public async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IReadOnlyList<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
