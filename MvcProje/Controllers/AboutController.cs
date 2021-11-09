using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using BusinessLayer.Concrete;

namespace MvcProje.Controllers
{
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
            AuthorManager authman = new AuthorManager();
            var authorlist = authman.GetAll();
            return PartialView(authorlist);
        }

        public ActionResult UpdateAbout()
        {
            return View();
        }
    }
}