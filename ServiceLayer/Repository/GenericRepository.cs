using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly BedBoxDbContext _context;

        public GenericRepository(BedBoxDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {

            return _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Task.FromResult(_context.Set<TEntity>());
        }

        public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {

            return _context.Set<TEntity>().Where(predicate);
        }
        public async Task<IEnumerable<TEntity>> WhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.FromResult(_context.Set<TEntity>().Where(predicate));
        }

        public void Insert(TEntity entity)
        {

            _context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {

            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {

            _context.Set<TEntity>().Remove(entity);
        }

       
    }
}
