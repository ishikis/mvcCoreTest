using CourseApp.Models;
using CourseApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace CourseApp.Controllers
{
    public class L04PartitialViewController : Controller
    {
        public IActionResult Index()
        {
             return View();
        }
        
        public IActionResult About()
        {
             return View();
             
        }
    }
}