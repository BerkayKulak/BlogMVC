using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;

namespace MvcProje.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private UserProfileManager userProfile = new UserProfileManager();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1(string p)
        {
            var mail = (string)Session["Mail"];
            p = mail;
            var profilevalues = userProfile.GetAuthorByMail(p);
            return PartialView(profilevalues);
        }

        public ActionResult BlogList()
        {
            int id = 2;
            var blogs = userProfile.GetBlogByAuthor(id);
            return View(blogs);
        }

    }
}