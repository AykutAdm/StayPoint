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
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(StayPointContext context) : base(context)
        {
        }

        public int GetStaffCount()
        {
            var context = new StayPointContext();
            var value = context.Staffs.Count();
            return value;
        }

        public List<Staff> Last4Staff()
        {
            var context = new StayPointContext();
            var values = context.Staffs.OrderByDescending(x => x.StaffId).Take(4).ToList();
            return values;
        }
    }
}
