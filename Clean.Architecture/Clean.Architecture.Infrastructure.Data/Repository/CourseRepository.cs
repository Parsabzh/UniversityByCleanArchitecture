using System;
using System.Collections.Generic;
using System.Text;
using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Domain.Models;
using Clean.Architecture.Infrastructure.Data.Context;

namespace Clean.Architecture.Infrastructure.Data.Repository
{
   public class CourseRepository:ICourseRepository
   {
       private readonly UniversityDbContext _db;

       public CourseRepository(UniversityDbContext db)
       {
           _db = db;
       }
        public IEnumerable<Course> GetCourses()
        {
            return _db.Courses;
        }

        public Course GetCourse(int courseId)
        {
            return _db.Courses.Find(courseId);
        }
   }
}
