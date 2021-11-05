﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;

namespace MvcProje.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        private BlogManager blogManager = new BlogManager();
        private AuthorManager authorManager = new AuthorManager();
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetail = blogManager.GetBlogById(id);
            return PartialView(authordetail);
        }

        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogauthorid = blogManager.GetAll().Where(x => x.BlogID == id).Select(y => y.AuthorID).FirstOrDefault();
            var authorblogs = blogManager.GetBlogByAuthor(blogauthorid);
            return PartialView(authorblogs);
        }

        public ActionResult AuthorList()
        {
            var authorList = authorManager.GetAll();
            return View(authorList);
        }
    }
}