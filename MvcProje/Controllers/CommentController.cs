using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;

namespace MvcProje.Controllers
{
    public class CommentController : Controller
    {
        
        CommentManager cm = new CommentManager();
        [AllowAnonymous]
        public PartialViewResult CommentList(int id)
        {
            var commentlist = cm.CommentByBlog(id);
            return PartialView(commentlist);
        }

        [HttpGet]
        [AllowAnonymous]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }

        [HttpPost]
        [AllowAnonymous]
        public PartialViewResult LeaveComment(Comment c)
        {
            cm.CommentAdd(c);
            return PartialView();
        }

        public ActionResult AdminCommentListTrue()
        {
            var commentList = cm.CommentByStatusTrue();
            return View(commentList);
        }

        public ActionResult AdminCommentListFalse()
        {
            var commentList = cm.CommentStatusFalse();
            return View(commentList);
        }


        public ActionResult StatusChangeToFalse(int id)
        {
            cm.CommentStatusChangeToFalse(id);
            return RedirectToAction("AdminCommentListTrue");
        }

        public ActionResult StatusChangeToTrue(int id)
        {
            cm.CommentStatusChangeToTrue(id);
            return RedirectToAction("AdminCommentListFalse");
        }

    }
}