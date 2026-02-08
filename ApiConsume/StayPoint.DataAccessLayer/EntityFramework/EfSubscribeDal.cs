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
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(StayPointContext context) : base(context)
        {
        }
    }
}
