using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DiOMSEntity;

namespace DiOMSRepositoryEntity
{
    public class GenericRepository<T> : IRepository<T> where T:class
    {
        private DiOMSContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(DiOMSContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
             //_dbSet.SqlQuery("store procedure @param1", new System.Data.SqlClient.SqlParameter("@param1", 1)); use for calling store procedure
            //context.Database.SqlQuery used for calling store procedure with multiple tables
        }

        public IQueryable<T> GetQuery
        {
            get
            {
                return _dbSet.AsQueryable();
            }
        }


        public IQueryable<T> Include(Expression<Func<T,object>> cond)
        {
            return _dbSet.Include(cond).AsQueryable(); 
        }

        public IQueryable<T> Include(params Expression<Func<T, object>>[] cond)
        {
            var query = _dbSet.AsQueryable();
            foreach (var express in cond)
            {
                query.Include(express);
            }
            return query;
        }

        public bool AddObject(T newObj)
        {
            try
            {
                _dbSet.Add(newObj);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteObject(int id)
        {
            try
            {
                T obj = _dbSet.Find(id);
                _dbSet.Remove(obj);
            }
            catch { return false; }
            return true;
        }

        public async Task<T> FindObject(int id)
        {
            return await _dbSet.FindAsync(id) ;
        }

        public  List<T> GetAll()
        {
            
                return _dbSet.ToList();
           
        }

        public T GetDat(Expression<Func<T, bool>> cond)
        {
            T obj = _dbSet.FirstOrDefault(cond);
            return obj;
        }

        public T Update(T obj)
        {
           return _dbSet.Attach(obj);
        }
    }
}
