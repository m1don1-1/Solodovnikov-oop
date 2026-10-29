using System.Collections.Generic;

namespace CorpFleet.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T item);
        List<T> GetAll();
        void Delete(int id);
    }
}