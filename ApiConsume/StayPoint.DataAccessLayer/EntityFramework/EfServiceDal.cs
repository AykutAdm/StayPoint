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
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(StayPointContext context) : base(context)
        {
        }
    }
}
