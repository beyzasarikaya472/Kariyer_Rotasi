using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "E-posta zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [Display(Name = "E-posta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur.")]
        [StringLength(30, ErrorMessage = "Şifre en az {2} en fazla {1} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı zorunludur.")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre tekrarı")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Tam Ad")]
        [StringLength(100, ErrorMessage = "Ad soyad 100 karakterden fazla olamaz.")]
        public string? FullName { get; set; }

        [Display(Name = "Yaş")]
        [Range(0, 100, ErrorMessage = "Lütfen geçerli bir yaş giriniz.")]
        public int? Age { get; set; }

        [Display(Name = "Telefon")]
        [StringLength(12, ErrorMessage = "Lütfen geçerli bir telefon numarası giriniz.", MinimumLength = 9)]
        public string? Phone { get; set; }

        [Display(Name = "Adres")]
        [StringLength(256, ErrorMessage = "Adresiniz 256 karakterden fazla olamaz.")]
        public string? Address { get; set; }

    }
}
