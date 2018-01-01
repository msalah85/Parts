using System.Collections.Generic;
using System.Linq;

namespace ShareWeb.CarsParts.Repository
{
    // https://www.youtube.com/watch?v=YG0EbTrLQUo&index=6&list=PLAPpPaAUVQyZJvtvWH9eOJcVkj7NLPQLk

    public class GenericRepository<T> : IRepository<T> where T : class
    {
        PartsContext db = new PartsContext();

        public T Add(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();

            return item;
        }

        public List<T> GetAll()
        {
            var list = db.Set<T>().ToList();
            return list;
        }
    }
}
