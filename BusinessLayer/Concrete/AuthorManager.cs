using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AuthorManager
    {
        private Repository<Author> repoauthor = new Repository<Author>();

        public List<Author> GetAll()
        {
            return repoauthor.List();
        }
    }
}
