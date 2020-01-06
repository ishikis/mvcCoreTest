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
            //Model Binding > ModelStateDictionary
            //AddModelError Hata Ekleme 
            //GetValidationState durum kontrolu saglarız
            //IsValid 
            if (string.IsNullOrEmpty(model.UserName))
            {
                ModelState.AddModelError(
                    nameof(model.UserName),
                    "UserName Zorunlu ALan");
            }

            if (string.IsNullOrEmpty(model.Email))
            {
                ModelState.AddModelError(
                    nameof(model.Email),
                    "Email Zorunlu ALan");
            }
            else if (!model.Email.Contains("@"))
            {
                ModelState.AddModelError(
                    nameof(model.Email),
                    "Email düzgün girilmedi");
            }
            if (string.IsNullOrEmpty(model.Password))
            {
                ModelState.AddModelError(
                    nameof(model.Password),
                    "Password Zorunlu ALan");
            }
            else if (model.Password.Length < 6)
            {
                ModelState.AddModelError(
                    nameof(model.Password),
                    "Parola min 6 karakter olmalı");
            }
            if (model.TermsAccepted)
            {
                ModelState.AddModelError(
                    nameof(model.TermsAccepted),
                    "Kullanım koşullarını kabul etmelisiniz.");
            }

            if (ModelState.IsValid)
                return View("Completed", model);
            else
                return View(model);
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