using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNet1.Controllers
{
    public class Courses : Controller
    {
        public IActionResult Index()
    {
        // return View();
        return Content("Sono Index");
    }
    public IActionResult Detail(string id)
    {
        return Content($"Sono detail, ho ricevuto l'id {id}");
    }
    }
}