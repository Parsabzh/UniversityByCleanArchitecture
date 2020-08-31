using System;
using System.Collections.Generic;
using System.Text;
using Clean.Architecture.Domain.Models;

namespace Clean.Architecture.Domain.Interfaces
{
  public interface ICourseRepository
  {
      IEnumerable<Course> GetCourses();
      Course GetCourse(int courseId);
  }
}
