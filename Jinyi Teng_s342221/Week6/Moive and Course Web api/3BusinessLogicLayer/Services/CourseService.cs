using System;
using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;
namespace _3BusinessLogicLayer.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseDal _CourseDal;
        public CourseService(ICourseDal CourseDal
        )
        {
            _CourseDal = CourseDal;
        }

        public async Task<CourseModel?> GetById(int CourseId)
        {
            return _CourseDal.GetById(CourseId);
        }

        public async Task<List<CourseModel>> GetAll()
        {
            return _CourseDal.GetAll();
        }

        public async Task<int> CreateCourse(CourseModel Course)
        {

            var newCourseId = _CourseDal.CreateCourse(Course);
            return newCourseId;
        }

        public async Task UpdateCourse(CourseModel Course)
        {
            _CourseDal.UpdateCourse(Course);
        }

        public async Task DeleteCourse(int CourseId)
        {
            try
            {

                _CourseDal.DeleteCourse(CourseId);
            }
            catch (Exception e)
            {

            }
        }
    }
}
