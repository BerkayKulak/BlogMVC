using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace MvcProje.Controllers
{
    public class CategoryController : Controller
    {
        
        private CategoryManager cm = new CategoryManager(new EfCategoryDal());

   

        [AllowAnonymous]
        public PartialViewResult BlogDetailsCategoryList()
        {
            var categoryvalues = cm.GetList();
            return PartialView(categoryvalues);
        }

        public ActionResult AdminCategoryList()
        {
            var categorylist = cm.GetList();
            return View(categorylist);
        }

        [HttpGet]
        public ActionResult AdminCategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminCategoryAdd(Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.TAdd(p);
                return RedirectToAction("AdminCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult CategoryEdit(int id)
        {

            Category category = cm.GetByID(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult CategoryEdit(Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.TUpdate(p);
                return RedirectToAction("AdminCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
          
        }

        public ActionResult CategoryDelete(int id)
        {
            cm.DeleteCategoryBL(id);
            return RedirectToAction("AdminCategoryList");
        }

        public ActionResult CategoryStatusTrue(int id)
        {
            cm.CategoryStatusTrueBL(id);
            return RedirectToAction("AdminCategoryList");
        }
    }
}