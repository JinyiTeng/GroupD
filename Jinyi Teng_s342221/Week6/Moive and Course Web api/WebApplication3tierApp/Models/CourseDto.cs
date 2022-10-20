
using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{

    public class CourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public DateTime ClassTime { set; get; }
        public string Teacher { set; get; }

    }

    public static class CourseDtoMapExtensions
    {
        public static CourseDto ToCourseDto(this CourseModel src)
        {
            var dst = new CourseDto();
            dst.CourseId = src.CourseId;
            dst.CourseName = src.CourseName;
            dst.ClassTime = src.ClassTime;
            dst.Teacher = src.Teacher;
            return dst;
        }

        public static CourseModel ToCourseModel(this CourseDto src)
        {
            var dst = new CourseModel();
            dst.CourseId = src.CourseId;
            dst.CourseName = src.CourseName;
            dst.ClassTime = src.ClassTime;
            dst.Teacher = src.Teacher;
            return dst;
        }
    }

}
