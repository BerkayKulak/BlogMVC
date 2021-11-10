using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UserProfileManager
    {
        private Repository<Author> repouser = new Repository<Author>();
        private Repository<Blog> repoblog = new Repository<Blog>();
        public List<Author> GetAuthorByMail(string p)
        {
            return repouser.List(x => x.Mail == p);
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return repoblog.List(x => x.AuthorID == id);
        }


    }


}
