using CourseApp.Models;
using CourseApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace CourseApp.Controllers
{
    public class L03PassingDataToViewsController : Controller
    {
        public IActionResult index()
        {
            var kurs = new Course() { name = "Kur Adı" };

            ViewData["course"] = kurs;
            ViewBag.course = kurs;
            ViewBag.count = 10;

            ViewData.Model = 1;

            //var viewResult = new ViewResult();
            // viewResult.ViewData.Model=kurs
            //return View(kurs);
            //View() içine yazdıgımız degeri ViewData.Model  içine de yazabliriz 

            //Viewe birden fazla modeli modelview oluşturark tek seferde gönderebiliriz.
            var vm = new CourseStudentViewModel();
            vm.Course = kurs;
            vm.Count = 10;
            return View(vm);
        }
    }
}