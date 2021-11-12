using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager:IAboutService
    {
        private Repository<About> repoabout= new Repository<About>();
        private IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

    
        public void UpdateAboutBM(About p)
        {
            About about = repoabout.Find(x => x.AboutID == p.AboutID);
            about.AboutContent1 = p.AboutContent1;
            about.AboutContent2 = p.AboutContent2;
            about.AboutImage1 = p.AboutImage1;
            about.AboutImage2 = p.AboutImage2;
            about.AboutID = p.AboutID;
             repoabout.Update(about);
        }

        public List<About> GetList()
        {
            return _aboutDal.List();
        }

        public void AboutAdd(About about)
        {
            throw new NotImplementedException();
        }

        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void AboutDelete(About about)
        {
            throw new NotImplementedException();
        }

        public void AboutUpdate(About about)
        {
            throw new NotImplementedException();
        }
    }
}
