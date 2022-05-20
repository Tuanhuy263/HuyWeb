using DiOMSEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiOMSRepositoryEntity
{
    public interface IUnitOfWork
    {
        bool CommitChange();
        DiOMSContext Context { get; }
        void CreateTransaction();
        void Commit();
        void Rollback();
        void Save();
        GenericRepository<T> GeneralRepository<T>() where T:class;
    }
}
