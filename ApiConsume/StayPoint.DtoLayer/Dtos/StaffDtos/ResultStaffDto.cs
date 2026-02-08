using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayPoint.DtoLayer.Dtos.StaffDtos
{
    public class ResultStaffDto
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string InstagramUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string FacebookUrl { get; set; }
    }
}
