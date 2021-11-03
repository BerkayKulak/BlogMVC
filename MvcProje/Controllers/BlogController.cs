using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using BusinessLayer.Concrete;

namespace MvcProje.Controllers
{
    public class BlogController : Controller
    {
        private BlogManager bm = new BlogManager();
        public ActionResult Index()
        {
            return View();
        }




        public PartialViewResult BlogList()
        {
            var bloglist = bm.GetAll();
            return PartialView(bloglist);
        }

        public PartialViewResult FeaturedPosts()
        {
            //1.Post Kategori idisi 1 olan ilk postun başlığını getirir.
            var posttitle1 = bm.GetAll().OrderByDescending(z=>z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage1 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate1 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.posttitle1 = posttitle1;
            ViewBag.postimage1 = postimage1;
            ViewBag.blogdate1 = blogdate1;

            return PartialView();
        }

        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }

        public PartialViewResult MailSubscribe()
        {
            return PartialView();
        }

        public ActionResult BlogDetails()
        {
            return View();
        }

        public PartialViewResult BlogCover()
        {
            return PartialView();
        }

        public PartialViewResult BlogReadAll()
        {
            return PartialView();
        }

        public ActionResult BlogByCategory()
        {
            return View();
        }
    }
}