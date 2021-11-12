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
        AboutManager abm = new AboutManager();
        public ActionResult Index()
        {
            var aboutcontent = abm.GetAll();
            return View(aboutcontent);
        }

        public PartialViewResult Footer()
        {
            
            var aboutContentList = abm.GetAll();
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
            var aboutList = abm.GetAll();
            return View(aboutList);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            abm.UpdateAboutBM(p);
            return RedirectToAction("UpdateAboutList");
        }
    }
}