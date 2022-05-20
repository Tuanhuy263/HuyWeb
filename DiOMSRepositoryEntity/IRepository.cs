using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiOMSRepositoryEntity
{
    interface IRepository<T> where T:class
    {
        List<T> GetAll();
        Task<T> FindObject(int id);
        T Update(T obj);
        bool DeleteObject(int id);
        bool AddObject(T newObj);
        IQueryable<T> GetQuery { get; }
        T GetDat(Expression<Func<T, bool>> cond);
        IQueryable<T> Include(Expression<Func<T, object>> cond);
        IQueryable<T> Include(params  Expression<Func<T, object>>[] cond);
    }
}
