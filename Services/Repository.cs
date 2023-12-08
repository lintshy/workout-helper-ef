using Microsoft.EntityFrameworkCore;
using workout_helper_2.Data;

namespace workout_helper_2.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly WorkoutHelperContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(WorkoutHelperContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual T Add(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public virtual IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
            return entities;
        }

        public int Count()
        {
            return _dbSet.Count();
        }

        public int Count(Func<T, bool> filter)
        {
            return _dbSet.Where(filter).Count();
        }

        public virtual void Delete(object id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                Delete(entity);
            }
        }

        public virtual void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public virtual T? Get(object id)
        {
            var x = _dbSet.Find(id);
            return x;
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void UpdateRange(IEnumerable<T> entities)
        {
            _dbSet.UpdateRange(entities);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public IQueryable<T> GetAll(Func<T, bool> filter)
        {
            return _dbSet.Where(filter).AsQueryable();
        }

        public T? First(Func<T, bool> filter)
        {
            return _dbSet.FirstOrDefault(filter);
        }

        public void DeleteRange(IEnumerable<T> entity)
        {
            _dbSet.RemoveRange(entity);
        }
    }
}
