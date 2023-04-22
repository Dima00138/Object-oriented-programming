using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseWork
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T? Get(string id);
        void Create(T item);
        void Update(T item, string columnName, string newVal);
        void Delete(T item, string id);
        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
    }

    public interface IUnitOfWork : IDisposable
    {
        IRepository<Shedule> Shedules { get; }
        //IRepository<Course> Courses { get; }
        void Save();
    }
}
