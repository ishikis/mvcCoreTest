using CourseApp.Models;
using CourseApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CourseApp.Controllers
{
    public class L05ViewComponentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}