using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DiOMSEntity;
using System.Data.Entity.Validation;

namespace DiOMSRepositoryEntity
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private DiOMSContext _context = null;
        private DbContextTransaction _objTran;
        private Dictionary<string, object> _repositories;
        private string _errorMessage = string.Empty;

        public UnitOfWork()
        {
            _context = new DiOMSContext();
        }

        public bool CommitChange()
        {
            int result = _context.SaveChangesAsync().Result;
            return result > 0 ? true : false;
        }

        public void Dispose()
        {
            if (_objTran != null)
            {
                _objTran.Dispose();
            }
            if(_repositories != null)
            {
                _repositories.Clear();
            }
            _context.Dispose();
        }

        public DiOMSContext Context
        {
            get { return _context; }
        }
        //This CreateTransaction() method will create a database Trnasaction so that we can do database operations by
        //applying do evrything and do nothing principle
        public void CreateTransaction()
        {
            _objTran = _context.Database.BeginTransaction();
        }
        //If all the Transactions are completed successfuly then we need to call this Commit() 
        //method to Save the changes permanently in the database
        public void Commit()
        {
            _objTran.Commit();
        }

        //If atleast one of the Transaction is Failed then we need to call this Rollback() 
        //method to Rollback the database changes to its previous state
        public void Rollback()
        {
            _objTran.Rollback();
            _objTran.Dispose();
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                    foreach (var validationError in validationErrors.ValidationErrors)
                        _errorMessage += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                throw new Exception(_errorMessage, dbEx);
            }
        }

        public GenericRepository<T> GeneralRepository<T>() where T : class
        {
            if (_repositories == null)
                _repositories = new Dictionary<string, object>();
            var type = typeof(T).Name;
            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<T>);
                var repositoryInstance = Activator.CreateInstance(typeof(GenericRepository<T>), _context);
                _repositories.Add(type, repositoryInstance);
            }
            return (GenericRepository<T>)_repositories[type];
        }
    }
}
