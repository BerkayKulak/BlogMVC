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

        public int EditAuthor(Author p)
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
            return repoauthor.Update(author);
        }

    }
}
