using Cargo_Database.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Cargo_Database.Repositorys
{
    internal abstract class Repo<TEntity> where TEntity : class
    {
        private readonly DataContext _context;

        protected Repo(DataContext context)
        {
            _context = context;
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }

        public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            try
            {
                var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
                return entity ?? null!;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            try
            {
                var entitys = await _context.Set<TEntity>().ToListAsync();
                return entitys ?? null!; ;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync();
                return entity ?? null!;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }

        public virtual async Task<bool> DeleteAsync(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }

        public virtual async Task<bool> ExistAsync(Expression<Func<TEntity, bool>> expression)
        {
            try
            {
                var exists = await _context.Set<TEntity>().AnyAsync(expression);
                return exists;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }
    }
}
