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
        private Repository<Blog> repoblog = new Repository<Blog>();

        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogById(int id)
        {
            return repoblog.List(x => x.BlogID == id);
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return repoblog.List(x => x.AuthorID == id);
        }

        public List<Blog> GetBlogByCategory(int id)
        {
            return repoblog.List(x => x.CategoryID == id);
        }

      

        public List<Blog> GetList()
        {
            return _blogDal.List();
        }

        public void TAdd(Blog t)
        {
            throw new System.NotImplementedException();
        }

        public void BlogAdd(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public Blog GetByID(int id)
        {
            return _blogDal.GetByID(id);
        }

        public void TDelete(Blog t)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Blog t)
        {
            throw new System.NotImplementedException();
        }

        public void BlogDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
