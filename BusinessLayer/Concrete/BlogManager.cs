using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        private Repository<Blog> repoblog = new Repository<Blog>();

        public List<Blog> GetAll()
        {
            return repoblog.List();
        }

        public List<Blog> BlogByID(int id)
        {
            return repoblog.List().Where(x => x.BlogID == id).ToList();
        }
    }
}
