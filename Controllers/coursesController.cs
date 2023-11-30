using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet1.Models.Services.Application;
using DotNet1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNet1.Controllers
{
    public class CoursesController : Controller
    {
    public IActionResult Index()
    {
        var courseService = new CourseService();
        List<CourseViewModel> courses = courseService.GetCourses();
        return View(courses);
        // return Content("Sono Index");
    }
    public IActionResult Detail(int id)
    {
        var courseService = new CourseService();
        CourseDetailViewModel viewModel = courseService.GetCourses(id);
        return View(viewModel);
    }
    }


}