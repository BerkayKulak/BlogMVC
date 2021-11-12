using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager
    {
        Repository<Contact> repocontact = new Repository<Contact>();

        public void BLContactAdd(Contact c)
        {
            repocontact.Insert(c);
        }

        public List<Contact> GetAll()
        {
            return repocontact.List();
        }

        public Contact GetContactDetails(int id)
        {
            return repocontact.Find(x => x.ContactID == id);
        }
    }
}
