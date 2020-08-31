using System;
using System.Collections.Generic;
using System.Text;
using Clean.Architecture.Application.Interfaces;
using Clean.Architecture.Application.ViewModels;
using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Domain.Models;

namespace Clean.Architecture.Application.Services
{
  public class CourseService:ICourseService
  {
      private readonly ICourseRepository _courseRepository;

      public CourseService(ICourseRepository courseRepository)
      {
          _courseRepository = courseRepository;
      }

      public CourseViewModel GetCourses()
      {
         return new CourseViewModel()
         {
             Courses = _courseRepository.GetCourses()
         };
      }


      public Course GetCourse(int courseId)
      {
          var model = _courseRepository.GetCourse(courseId);
          return model;
      }
  }
}
