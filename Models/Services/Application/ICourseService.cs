using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet1.Models.ViewModels;

namespace DotNet1.Models.Services.Application
{
    public interface ICourseService
    {
        List<CourseViewModel> GetCourses();
        CourseDetailViewModel GetCourse(int id);
    
    }
}