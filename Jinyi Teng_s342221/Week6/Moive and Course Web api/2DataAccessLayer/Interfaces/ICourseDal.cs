﻿using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface ICourseDal
    {

        CourseModel? GetById(int CourseId);
        List<CourseModel> GetAll();

        int CreateCourse(CourseModel Course);
        void UpdateCourse(CourseModel Course);
        void DeleteCourse(int CourseId);
    }
}
