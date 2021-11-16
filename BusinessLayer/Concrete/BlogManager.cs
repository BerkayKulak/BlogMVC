using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager:IBlogService
    {

        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.List(x => x.BlogID == id);
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return _blogDal.List(x => x.AuthorID == id);
        }

        public List<Blog> GetBlogByCategory(int id)
        {
            return _blogDal.List(x => x.CategoryID == id);
        }

      

        public List<Blog> GetList()
        {
            return _blogDal.List();
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }


        public Blog GetByID(int id)
        {
            return _blogDal.GetByID(id);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

  
    }
}
