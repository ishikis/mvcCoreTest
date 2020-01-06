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
            // //Kontroller içinde istedigimiz yonetmek istersek
            // //Model Binding > ModelStateDictionary
            // //AddModelError Hata Ekleme 
            // //GetValidationState durum kontrolu saglarız
            // //IsValid 
            // if (string.IsNullOrEmpty(model.UserName))
            // {
            //     ModelState.AddModelError(
            //         nameof(model.UserName),
            //         "UserName Zorunlu ALan");
            // }

            // if (string.IsNullOrEmpty(model.Email))
            // {
            //     ModelState.AddModelError(
            //         nameof(model.Email),
            //         "Email Zorunlu ALan");
            // }
            // else if (!model.Email.Contains("@"))
            // {
            //     ModelState.AddModelError(
            //         nameof(model.Email),
            //         "Email düzgün girilmedi");
            // }
            // if (string.IsNullOrEmpty(model.Password))
            // {
            //     ModelState.AddModelError(
            //         nameof(model.Password),
            //         "Password Zorunlu ALan");
            // }
            // else if (model.Password.Length < 6)
            // {
            //     ModelState.AddModelError(
            //         nameof(model.Password),
            //         "Parola min 6 karakter olmalı");
            // }
            // if (model.TermsAccepted)
            // {
            //     ModelState.AddModelError(
            //         nameof(model.TermsAccepted),
            //         "Kullanım koşullarını kabul etmelisiniz.");
            // }

            // if (ModelState.IsValid)
            return View("Completed", model);
            // else
            // return View(model);
        }
    }

    // Model içinde Kottrol etmek istersek
    public class Register
    {
        [Required]//Zorunlu
        [Display(Name = "User Name")]//asp-for kullanıldıgnda labelde gorunur 
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Email Giriniz.")]//ErrorMessage Hata mesajını düzenleriz
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email fomatı uygun degil")]
        public string Email { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 6, ErrorMessage = "Max 8 karakter")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Parola takrarı hatalı")]
        public string RePassword { get; set; }

        [UIHint("Date")]
        public DateTime BirthDate { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage = "Koşulları kabul etmelisiniz.")]
        public bool TermsAccepted { get; set; }
    }
}