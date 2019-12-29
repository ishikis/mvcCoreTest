using CourseApp.Models;
using CourseApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CourseApp.Controllers
{
    public class L06UsingFormsController : Controller
    {
        public IActionResult Index()
        {
            var Course = new Course();

            return View(Course);
        }
        public IActionResult Search(string q)
        {
            if (string.IsNullOrWhiteSpace(q))
                //TODO: Implement Realistic Implementation
                return View();
            //kontrole gitmeden direk viewi çagırıyoruz
            //yani controler Searh view index 
            var Course = new Course();
            return View("Index", Course);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }


        [HttpPost]
        //public IActionResult Create(string name,string description,bool isPublished)
        public IActionResult Create(Course course)
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
    }
}