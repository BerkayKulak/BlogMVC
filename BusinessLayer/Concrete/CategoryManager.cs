using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private Repository<Category> repoCategory = new Repository<Category>();

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return repoCategory.List();
        }

        public void DeleteCategoryBL(int id)
        {
            Category category = repoCategory.Find(x => x.CategoryID == id);
            category.CategoryStatus = false; 
            repoCategory.Update(category);
        }

        public void CategoryStatusTrueBL(int id)
        {
            Category category = repoCategory.Find(x => x.CategoryID == id);
            category.CategoryStatus = true;
            repoCategory.Update(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
