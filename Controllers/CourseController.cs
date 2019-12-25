using System.Linq;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //    public IActionResult Apply(string Name, string Email, string Phone, bool Confirm)
        public IActionResult Apply(Student student)
        {
            //Validation işlemleri kontrol eder
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View(student);
            }
        }

        [HttpGet]
        public IActionResult Apply()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Apply2()
        {

            return View();
        }
        public IActionResult List()
        {
            var students = Repository.Students.Where(x => x.Confirm == true).ToList();
            return View(students);
        }

        public IActionResult Details()
        {
            var course = new Course();
            course.name = "Core Mvc Kursu";
            course.description = "Güzel bir bilgi";
            course.isPublished = true;
            return View(course);
            //kontroller isminden farklı bir view çagırmak istersek
            //return View("Details");
            //return View("Details",course);
        }

    }
}