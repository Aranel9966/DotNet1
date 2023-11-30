using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet1.Models;


namespace DotNet1.Models.ViewModels
{
    public class CourseDetailViewModel : CourseViewModel
    {
     public string? Description { get; set; }   
     public List<LessonViewModel>? Lessons { get; set; }   
    }
    // public TimeSpan TotalCourseDuration{
    //     get=>TimeSpan.FromSeconds(Lessons?.Sum(1 => 1.Duration.TotalSeconds))?? 0);
    // }
}