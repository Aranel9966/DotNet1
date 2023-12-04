using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet1.Models.ViewModels;

namespace DotNet1.Models.Services.Application
{
    public class CourseService : ICourseService
    {
        public List<CourseViewModel> GetCourses()
        {

            var courseList= new List<CourseViewModel>();
            var rand = new Random();
            for(int i = 1; i<=10;i++){
                var course =new CourseViewModel
                    {
                        Id = i,
                        Rating = rand.Next(10,50) / 10.0,
                        Title="corso",
                        Price= 12.11 ,
                    };
                    courseList.Add(course);
                }
            return courseList;
        }

        public CourseDetailViewModel GetCourses(int id)
        {
            
            var rand = new Random();
            var course =new CourseDetailViewModel
                {
                    Id = id,
                    Rating = rand.Next(10,50) / 10.0,
                    Title ="corso",
                    Price = 12.11 ,
                    Description = $"Descrizione {id}",
                    Lessons = new List<LessonViewModel>()
                };
            for(var i = 1; i<=5;i++){
                var lesson =new LessonViewModel{
                    Title =$"Lezione {i}",
                    Duration = TimeSpan.FromSeconds(rand.Next(40,90))
                };
            course.Lessons.Add(lesson);
            }
            
            return course;
          
        }

        CourseDetailViewModel ICourseService.GetCourse(int id)
        {
            throw new NotImplementedException();
        }

        // List<CourseService> ICourseService.GetCourses()
        // {
        //     throw new NotImplementedException();
        // }
    }
}


