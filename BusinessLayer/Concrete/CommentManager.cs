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
    public class CommentManager:ICommentService
    {
        Repository<Comment> repocomment = new Repository<Comment>();
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> CommentList()
         {
             return repocomment.List();
         }

         public List<Comment> CommentByBlog(int id)
         {
             return _commentDal.List(x => x.BlogID == id);
         }

         public List<Comment> CommentByStatusTrue()
         {
             return _commentDal.List(x => x.CommentStatus == true);
         }


         public List<Comment> CommentStatusFalse()
         {
             return repocomment.List(x => x.CommentStatus == false);
         }

         public List<Comment> GetList()
         {
             throw new NotImplementedException();
         }

         public void CommentAdd(Comment c)
         {
             repocomment.Insert(c);
         }

         public Comment GetByID(int id)
         {
             throw new NotImplementedException();
         }

         public void CommentDelete(Comment comment)
         {
             throw new NotImplementedException();
         }

         public void CommentUpdate(Comment comment)
         {
             throw new NotImplementedException();
         }

         public void CommentStatusChangeToFalse(int id)
         {
             Comment comment = _commentDal.Find(x => x.CommentID == id);
             comment.CommentStatus = false;
             _commentDal.Update(comment);
         }

        public void CommentStatusChangeToTrue(int id)
        {
            Comment comment = _commentDal.Find(x => x.CommentID == id);
            comment.CommentStatus = true;
            _commentDal.Update(comment);
        }

    }
}

