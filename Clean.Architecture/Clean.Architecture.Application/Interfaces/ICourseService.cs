using Clean.Architecture.Application.ViewModels;
using Clean.Architecture.Domain.Models;

namespace Clean.Architecture.Application.Interfaces
{
   public interface ICourseService
    
   {
       CourseViewModel GetCourses();

       Course GetCourse(int courseId);
   }
}
