using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Display(Name = "Namee")]
        [Required(ErrorMessage = "İsminizi Giriniz!")]
        [MinLength(3)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mail Adresinizi Giriniz!")]
        [EmailAddress(ErrorMessage = "E mail Adresinizi Düzgün giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon Numaranızı Giriniz!")]
        public string Phone { get; set; }
        public bool? Confirm { get; set; }
    }
}