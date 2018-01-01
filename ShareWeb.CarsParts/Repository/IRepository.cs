using System.Collections.Generic;

namespace ShareWeb.CarsParts.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T Add(T item);
    }
}
