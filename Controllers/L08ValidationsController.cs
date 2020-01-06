using System;
using System.ComponentModel.DataAnnotations;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CourseApp.Controllers
{
    public class L08ValidationsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Register", new Register() { BirthDate = DateTime.Now });
        }

        [HttpPost]
        public IActionResult Register(Register model)
        {
            return View("Completed", model);
        }
    }

    public class Register
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [UIHint("Date")]
        public DateTime BirthDate { get; set; }
        public bool TermsAccepted { get; set; }
    }
}