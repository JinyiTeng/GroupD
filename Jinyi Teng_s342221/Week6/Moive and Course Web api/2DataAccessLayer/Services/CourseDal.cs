﻿using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _2DataAccessLayer.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Services
{
    public class CourseDal : ICourseDal
    {

        private DBEntitiesContext _db;
        public CourseDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; 
        }


        public List<CourseModel> GetAll()
        {
            var result = _db.Course.ToList();

            var returnObject = new List<CourseModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToCourseModel());
            }

            return returnObject;
        }

        public CourseModel? GetById(int CourseId)
        {
            var result = _db.Course.SingleOrDefault(x => x.CourseId == CourseId);
            return result?.ToCourseModel();
        }


        public int CreateCourse(CourseModel Course)
        {
            var newCourse = Course.ToCourse();
            _db.Course.Add(newCourse);
            _db.SaveChanges();
            return newCourse.CourseId;
        }


        public void UpdateCourse(CourseModel Course)
        {
            var existingCourse = _db.Course
                .SingleOrDefault(x => x.CourseId == Course.CourseId);

            if (existingCourse == null)
            {
                throw new ApplicationException($"Course {Course.CourseId} does not exist.");
            }
            Course.ToCourse(existingCourse);

            _db.Update(existingCourse);
            _db.SaveChanges();
        }

        public void DeleteCourse(int CourseId)
        {
            var efModel = _db.Course.Find(CourseId);
            _db.Course.Remove(efModel);
            _db.SaveChanges();


        }
    }
}
