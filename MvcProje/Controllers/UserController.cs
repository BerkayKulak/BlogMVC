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
        public ActionResult Index(string p)
        {
            p = "berkay@gmail.com";
            var profilevalues = userProfile.GetAuthorByMail(p);
            return View(profilevalues);
        }

    }
}