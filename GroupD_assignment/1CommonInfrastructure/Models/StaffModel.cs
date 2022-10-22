using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class StaffModel
    {
        public int StaffId { get; set; } // int
        public string StaffName { get; set; } // nvarchar(400)
        public string StaffPhone { get; set; }
        public string StaffPosition { get; set; }
        public string StaffShift { get; set; }
    }

}
