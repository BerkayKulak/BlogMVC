using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace MvcProje.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private UserProfileManager userProfile = new UserProfileManager();
        private BlogManager bm = new BlogManager();
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1(string p)
        {
            p = (string)Session["Mail"];
            var profilevalues = userProfile.GetAuthorByMail(p);
            return PartialView(profilevalues);
        }

        public ActionResult BlogList(string p)
        {
            p = (string)Session["Mail"];
  
            int id = c.Author.Where(x => x.Mail == p).Select(y=>y.AuthorID).FirstOrDefault();
            var blogs = userProfile.GetBlogByAuthor(id);
            return View(blogs);
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            Blog blog = bm.FindBlog(id);
            
            List<SelectListItem> values = (from x in c.Categories.ToList()
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryID.ToString()
                }).ToList();

            ViewBag.values = values;

            List<SelectListItem> values2 = (from x in c.Author.ToList()
                select new SelectListItem
                {
                    Text = x.AuthorName,
                    Value = x.AuthorID.ToString()
                }).ToList();

            ViewBag.values2 = values2;
            return View(blog);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog p)
        {
            bm.UpdateBlog(p);
            return RedirectToAction("BlogList");
        }

    }
}