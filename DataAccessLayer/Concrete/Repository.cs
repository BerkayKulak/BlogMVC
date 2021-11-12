using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private Context c = new Context();

        private DbSet<T> _object;// burası bizim entity sınıflarımız

        public Repository()
        {
            // Benim Context üzerinden göndermiş olduğum sınıfımı _object field'ına ata
            _object = c.Set<T>();
        }


        public List<T> List()
        {
            return _object.ToList();
        }

        public void Insert(T p)
        {
            _object.Add(p);
             c.SaveChanges();
        }

        public void Update(T p)
        {
             c.SaveChanges();
        }

        public void Delete(T p)
        {
            _object.Remove(p);
             c.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }
    }
}
