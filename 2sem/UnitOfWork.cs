using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data;

namespace CourseWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OracleDbContext _context;
        private readonly IDbTransaction _transaction;
        private bool _disposed;
        private Dictionary<Type, object> _repositories;

        public UnitOfWork(OracleDbContext context)
        {
            _context = context;
            _context.conn.Open();
            _repositories = new Dictionary<Type, object>();
            _transaction = _context.conn.BeginTransaction();
        }

        public IRepository<Shedule> Shedules
        {
            get
            {
                return GetRepository<Shedule>();
            }
        }

        public IRepository<Route> Routes
        {
            get
            {
                return GetRepository<Route>();
            }
        }

        public void Save()
        {
            try
            {
                _transaction.Commit();
            }
            catch (Exception)
            {
                _transaction.Rollback();
                throw;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
            {
                return (IRepository<T>)_repositories[typeof(T)];
            }
            

            if (typeof(T) == typeof(Shedule))
            {
                var repositoryInstance = new SheduleRepository(_context);
                _repositories.Add(typeof(T), repositoryInstance);
                return (IRepository<T>)repositoryInstance;
            }
            else
            {
                var repositoryType = typeof(Repository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
                _repositories.Add(typeof(T), repositoryInstance);
                return (IRepository<T>)repositoryInstance;
            }

        }
    }
}
