using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> repocomment = new Repository<Comment>();
         public List<Comment> CommentList()
         {
             return repocomment.List();
         }

         public List<Comment> CommentByBlog(int id)
         {
             return repocomment.List(x => x.BlogID == id);
         }
    }
}

