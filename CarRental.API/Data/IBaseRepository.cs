using System.Collections.Generic;
using System.Threading.Tasks;
using CarRental.API.Models;

namespace CarRental.API.Data
{
    public interface IBaseRepository<T> where T: class
    {
        void Add(T entity);
        void Delete(T entity);
        Task<bool> SaveAll();
        Task<IEnumerable<T>> GetObjects();
        Task<T> GetObject(int id);
    }
}