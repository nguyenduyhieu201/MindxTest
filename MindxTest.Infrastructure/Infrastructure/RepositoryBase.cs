using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MindxTest.Infrastructure.Infrastructure
{

    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        #region Properties
        public MindxDbContext _context = null;
        public DbSet<T> dbSet = null;
        private IDbFactory DbFactory;
        protected MindxDbContext Init
        {
            get { return _context ?? (_context = DbFactory.Init()); }
        }
        #endregion
        public RepositoryBase()
        {
            this._context = new MindxDbContext();
            dbSet = _context.Set<T>();
        }
        public RepositoryBase(MindxDbContext _context)
        {
            this._context = _context;
            dbSet = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }
        public T GetById(object id)
        {
            return dbSet.Find(id);
        }
        public void Insert(T obj)
        {
            dbSet.Add(obj);
        }
        public void Update(T obj)
        {
            dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = dbSet.Find(id);
            dbSet.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}