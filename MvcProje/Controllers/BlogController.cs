using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using PagedList;
using PagedList.Mvc;

namespace MvcProje.Controllers
{
    public class BlogController : Controller
    {
        private BlogManager bm = new BlogManager();
        public ActionResult Index()
        {
            return View();
        }


        public PartialViewResult BlogList(int page = 1)
        {
            var bloglist = bm.GetAll().ToPagedList(page,6);
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


            //2.Post Kategori idisi 1 olan ilk postun başlığını getirir.
            var posttitle2 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage2 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate2 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.posttitle2 = posttitle2;
            ViewBag.postimage2 = postimage2;
            ViewBag.blogdate2 = blogdate2;

            //3.Post Kategori idisi 1 olan ilk postun başlığını getirir.
            var posttitle3 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage3 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate3 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.posttitle3 = posttitle3;
            ViewBag.postimage3 = postimage3;
            ViewBag.blogdate3 = blogdate3;

            //4.Post Kategori idisi 1 olan ilk postun başlığını getirir.
            var posttitle4 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage4 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate4 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.posttitle4 = posttitle4;
            ViewBag.postimage4 = postimage4;
            ViewBag.blogdate4 = blogdate4;

            //5.Post Kategori idisi 1 olan ilk postun başlığını getirir.
            var posttitle5 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 6).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage5 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 6).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate5 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 6).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.posttitle5 = posttitle5;
            ViewBag.postimage5 = postimage5;
            ViewBag.blogdate5 = blogdate5;


            return PartialView();
        }

        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }


        public ActionResult BlogDetails()
        {

            return View();
        }

        public PartialViewResult BlogCover(int id)
        {
            var BlogDetailsList = bm.GetBlogById(id);
            return PartialView(BlogDetailsList);
        }

        public PartialViewResult BlogReadAll(int id)
        {
            var BlogDetailsList = bm.GetBlogById(id);
            return PartialView(BlogDetailsList);
        }

        public ActionResult BlogByCategory(int id)
        {
            var BlogListByCategory = bm.GetBlogByCategory(id);
            var CategoryName = bm.GetBlogByCategory(id).Select(y => y.Category.CategoryName).FirstOrDefault();
            ViewBag.CategoryName = CategoryName;
            var CategoryDesc = bm.GetBlogByCategory(id).Select(y => y.Category.CategoryDescription).FirstOrDefault();
            ViewBag.CategoryDesc = CategoryDesc;
            return View(BlogListByCategory);
        }

        public ActionResult AdminBlogList()
        {
            var bloglist = bm.GetAll();
            return View(bloglist);
        }

        [HttpGet]
        public ActionResult AddNewBlog()
        {
            Context c = new Context();
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

            return View();
        }

        [HttpPost]
        public ActionResult AddNewBlog(Blog b)
        {
            bm.BlogAddBL(b);
            return RedirectToAction("AdminBlogList");
        }


        public ActionResult DeleteBlog(int id)
        {
            bm.DeleteBlogBL(id);
            return RedirectToAction("AdminBlogList");
        }
    }
}