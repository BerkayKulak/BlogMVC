﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SubscribeMailManager
    {
        private Repository<SubscribeMail> reposubscribemail = new Repository<SubscribeMail>();
        public void BLAdd(SubscribeMail p)
        {

            reposubscribemail.Insert(p);
        }
    }
}
