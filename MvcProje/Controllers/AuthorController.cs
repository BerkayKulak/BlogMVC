using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;

namespace MvcProje.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        private BlogManager bm = new BlogManager();
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetail = bm.GetBlogById(id);
            return PartialView(authordetail);
        }

        public PartialViewResult AuthorPopularPost()
        {
            return PartialView();
        }
    }
}