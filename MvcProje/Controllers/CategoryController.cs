using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using BusinessLayer.Concrete;

namespace MvcProje.Controllers
{
    public class CategoryController : Controller
    {
        
        private CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            var categoryvalues = cm.GetAll();
            return View(categoryvalues);
        }

        public PartialViewResult BlogDetailsCategoryList()
        {
            return PartialView();
        }
    }
}