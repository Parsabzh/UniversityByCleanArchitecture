using Clean.Architecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Architecture.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
