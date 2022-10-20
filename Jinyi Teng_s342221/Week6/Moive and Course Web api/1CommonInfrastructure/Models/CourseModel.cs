using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class CourseModel
    {
        public int CourseId { get; set; } 
        public string CourseName { get; set; } 
        public DateTime ClassTime { set; get; }
        public string Teacher { set; get; }
    }
}
