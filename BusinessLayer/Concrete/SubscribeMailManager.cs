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
    public class SubscribeMailManager:IMailService
    {

        private IMailDal _mailDal;

        public SubscribeMailManager(IMailDal mailDal)
        {
            _mailDal = mailDal;
        }


        public List<SubscribeMail> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(SubscribeMail t)
        {
            _mailDal.Insert(t);
        }

        public SubscribeMail GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubscribeMail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubscribeMail t)
        {
            throw new NotImplementedException();
        }
    }
}
