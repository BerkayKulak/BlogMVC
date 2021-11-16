using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> GetBlogById(int id);
        List<Blog> GetBlogByAuthor(int id);
        List<Blog> GetBlogByCategory(int id);
    }
}
