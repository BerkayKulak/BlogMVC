using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AuthorManager:IAuthorService
    {
        private IAuthorDal _authorDal;
        private Repository<Author> repoauthor = new Repository<Author>();

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }


        public List<Author> GetList()
        {
            return _authorDal.List();
        }

        public void TAdd(Author t)
        {
            _authorDal.Insert(t);
        }

    

        public Author GetByID(int id)
        {
            return _authorDal.GetByID(id);
        }

        public void TDelete(Author t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Author t)
        {
            _authorDal.Update(t);
        }

        public void AuthorDelete(Author author)
        {
            throw new NotImplementedException();
        }

   
    }
}
