using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcProje.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        // GET: About
        AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var aboutcontent = abm.GetList();
            return View(aboutcontent);
        }

        public PartialViewResult Footer()
        {
            
            var aboutContentList = abm.GetList();
            return PartialView(aboutContentList);
        }

        public PartialViewResult MeetTheTeam()
        {
            AuthorManager authman = new AuthorManager(new EfAuthorDal());
            var authorlist = authman.GetList();
            return PartialView(authorlist);
        }

        [HttpGet]
        public ActionResult UpdateAboutList()
        {
            var aboutList = abm.GetList();
            return View(aboutList);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            abm.TUpdate(p);
            return RedirectToAction("UpdateAboutList");
        }
    }
}