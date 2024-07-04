using JobPortal.Data.Entities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class CreateCVViewModel
    {
        [Display(Name = "Sertifika")]
        [Required(ErrorMessage = "Lütfen sertifikanızı giriniz")]
        [StringLength(100, ErrorMessage = "Sertifikanız 100 karakterden fazla olamaz.")]
        public string Certificate { get; set; }

        [Display(Name = "Ana Dal")]
        [Required(ErrorMessage = "Lütfen ana dalınızı giriniz")]
        [StringLength(100, ErrorMessage = "Ana dalınız 50 karakterden fazla olamaz.")]
        public string Major { get; set; }

        [Display(Name = "Mezuniyet Yeri")]
        [Required(ErrorMessage = "Lütfen mezun olduğunuz yeri giriniz")]
        [StringLength(100, ErrorMessage = "Mezuniyet yeriniz 50 karakterden fazla olamaz.")]
        public string GraduatedAt { get; set; }

        [Display(Name = "Ortalamanız")]
        [Required(ErrorMessage = "Lütfen ortalamanızı giriniz")]
        [Range(0, 4, ErrorMessage = "Lütfen geçerli bir ortalama giriniz (0-4).")]
        public float GPA { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Lütfen açıklamanızı giriniz")]
        public string Description { get; set; }

        [Display(Name = "Tanıtım")]
        [Required(ErrorMessage = "Lütfen kendinizi tanıtınız")]
        public string Introduce { get; set; }

        [Display(Name = "CV Resminiz")]
        public IFormFile UrlImage { get; set; }

        [Display(Name = "Telefon Numaranız")]
        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz")]
        [StringLength(20, ErrorMessage = "Lütfen geçerli bir telefon numarası giriniz.", MinimumLength = 9)]
        public string Phone { get; set; }

        [Display(Name = "E-posta Adresiniz")]
        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz")]
        [StringLength(50, ErrorMessage = "E-posta adresiniz 50 karakterden fazla olamaz.")]
        public string Email { get; set; }

    }
}
