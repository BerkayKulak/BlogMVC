using System;
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
    }
}
