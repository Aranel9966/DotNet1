using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet1.Models.ViewModels;

namespace DotNet1.Models.Services.Application
{
    public class CourseService
    {
        public List<CourseViewModel> GetCourses()
        {
            var courseList= new List<CourseViewModel>();
            for(int i = 1; i<=10;i++){

            var course =new CourseViewModel
            {
                Id = i,
                Title="corso",
                Price= 12.11 ,
            };
            courseList.Add(course);
            }
            
            return courseList;
          
        }
    }
}


