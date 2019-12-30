using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{

    // [Route("api/[action]/[id?]")]//api/about
    public class HomeController : Controller
    {

        // [Route("all")]//Home/index Çalışmaz bu action için sadece all yazarak çalışır
        // [Route("[Controller]/all")]//Home/all yazarak çalışır

        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.UserName = "İslam";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }


    }
}