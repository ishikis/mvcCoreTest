using CourseApp.Models;
using CourseApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CourseApp.Controllers
{
    public class L04PartitialViewController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category>()
            {
                new Category(){Name="Kategori 1"},
                new Category(){Name="Kategori 2"},
                new Category(){Name="Kategori 3"}
            };


            return View(categories);
        }

        public IActionResult About()
        {
            var categories = new List<Category>()
            {
                new Category(){Name="Kategori 1"},
                new Category(){Name="Kategori 2"},
                new Category(){Name="Kategori 3"}
            };


            return View(categories);
        }
    }
}