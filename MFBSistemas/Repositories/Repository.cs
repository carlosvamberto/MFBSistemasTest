using MFBSistemas.Models;
using Microsoft.EntityFrameworkCore;

namespace MFBSistemas.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly LocalDBMSSQLLocalDBContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(LocalDBMSSQLLocalDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
