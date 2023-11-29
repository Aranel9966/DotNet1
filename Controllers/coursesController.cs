using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNet1.Controllers
{
    public class CoursesController : Controller
    {
    public IActionResult Index()
    {
        var courseService = new CourseService();
        List<CourseViewModel> courses = courseService.GetServices();
        return View(courses);
        // return Content("Sono Index");
    }
    public IActionResult Detail(string id)
    {
        // return Content($"Sono detail, ho ricevuto l'id {id}");
        return View();

    }
    }

    internal class CourseViewModel
    {
    }

    internal class CourseService
    {
        public CourseService()
        {
        }
    }
}