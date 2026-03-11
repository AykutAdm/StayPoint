using Microsoft.EntityFrameworkCore;
using StayPoint.DataAccessLayer.Abstract;
using StayPoint.DataAccessLayer.Concrete;
using StayPoint.DataAccessLayer.Repositories;
using StayPoint.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayPoint.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(StayPointContext context) : base(context)
        {
        }

        public List<Contact> ContactListWithCategory()
        {
            var context = new StayPointContext();
            var values = context.Contacts.Include(x => x.MessageCategory).ToList();
            return values;
        }

        public int GetContactCount()
        {
            var context = new StayPointContext();
            return context.Contacts.Count();
        }
    }
}