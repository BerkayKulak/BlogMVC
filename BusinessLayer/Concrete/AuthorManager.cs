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

        public int AddAuthorBL(Author author)
        {
            if (author.AuthorName == "" || author.AboutShort == "" || author.AuthorTitle == "")
            {
                return -1;
            }

            return repoauthor.Insert(author);
        }

        public Author FindAuthor(int id)
        {
            return repoauthor.Find(x => x.AuthorID == id);
        }

        //public int UpdateAuthor(Author p)
        //{
        //    Author blog = repoauthor.Find(x => x.AuthorID == p.BlogID);
        //    blog.AuthorTitle = p.AuthorTitle;
        //    blog.BlogContent = p.BlogContent;
        //    blog.BlogDate = p.BlogDate;
        //    blog.BlogImage = p.BlogImage;
        //    blog.CategoryID = p.CategoryID;
        //    blog.AuthorID = p.AuthorID;
        //    return repoblog.Update(blog);
        //}

    }
}
