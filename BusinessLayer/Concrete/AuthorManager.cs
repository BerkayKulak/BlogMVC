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


        public Author FindAuthor(int id)
        {
            return repoauthor.Find(x => x.AuthorID == id);
        }

        public void EditAuthor(Author p)
        {
            Author author = repoauthor.Find(x => x.AuthorID == p.AuthorID);
            author.AboutShort = p.AboutShort;
            author.AuthorName = p.AuthorName;
            author.AuthorImage = p.AuthorImage;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorTitle = p.AuthorTitle;
            author.Mail = p.Mail;
            author.Password = p.Password;
            author.PhoneNumber = p.PhoneNumber;
            repoauthor.Update(author);
        }

        public List<Author> GetList()
        {
            return _authorDal.List();
        }

        public void AuthorAdd(Author author)
        {
            _authorDal.Insert(author);
        }

        public Author GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void AuthorDelete(Author author)
        {
            throw new NotImplementedException();
        }

        public void AuthorUpdate(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
