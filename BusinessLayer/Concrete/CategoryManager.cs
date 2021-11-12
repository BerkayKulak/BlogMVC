﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        private Repository<Category> repoCategory = new Repository<Category>();

        public List<Category> GetAll()
        {
            return repoCategory.List();
        }


        public int CategoryAddBL(Category p)
        {
            if (p.CategoryName == "" || p.CategoryDescription == "" || p.CategoryName.Length <= 3 || p.CategoryDescription.Length <= 3)
            {
                return -1;
            }

            return repoCategory.Insert(p);
        }

        public Category FindCategory(int id)
        {
            return repoCategory.Find(x => x.CategoryID == id);
        }

        public int EditCategory(Category p)
        {
            Category category = repoCategory.Find(x => x.CategoryID == p.CategoryID);
            if (p.CategoryName == "" || p.CategoryName.Length <= 4 | p.CategoryName.Length >= 30)
            {
                return -1;
            }
            category.CategoryName = p.CategoryName;
            category.CategoryDescription = p.CategoryDescription;
            return repoCategory.Update(category);
        }
    }
}
