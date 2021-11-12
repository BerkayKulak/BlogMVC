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

        public void BlogAddBL(Blog p)
        {
            

             repoblog.Insert(p);
        }

        public void DeleteBlogBL(int p)
        {
            Blog blog = repoblog.Find(x => x.BlogID == p);
             repoblog.Delete(blog);
        }

        public Blog FindBlog(int id)
        {
            return repoblog.Find(x => x.BlogID == id);
        }

        public void UpdateBlog(Blog p)
        {
            Blog blog = repoblog.Find(x => x.BlogID == p.BlogID);
            blog.BlogTitle = p.BlogTitle;
            blog.BlogContent = p.BlogContent;
            blog.BlogDate = p.BlogDate;
            blog.BlogImage = p.BlogImage;
            blog.CategoryID = p.CategoryID;
            blog.AuthorID = p.AuthorID;
             repoblog.Update(blog);
        }

        public List<Blog> GetList()
        {
            return _blogDal.List();
        }

        public void BlogAdd(Blog blog)
        {
            throw new System.NotImplementedException();
        }

        public Blog GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public void BlogDelete(Blog blog)
        {
            throw new System.NotImplementedException();
        }

        public void BlogUpdate(Blog blog)
        {
            throw new System.NotImplementedException();
        }
    }
}
