﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class RegisterEmployerViewModel
    {
        [Required(ErrorMessage = "E-posta hesabı girişi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [Display(Name = "E-posta hesabı girişi")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Şifre gerekli.")]
        [StringLength(30, ErrorMessage = "Şifre en az {2} en fazla {1} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı gerekli.")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre tekrarı")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Şirket adı")]
        [StringLength(100, ErrorMessage = "Şirket adı 100 karakterden fazla olamaz.")]
        public string? FullName { get; set; }

        [Display(Name = "Şirket genel bakış")]
        public string? Description { get; set; }

        [Display(Name = "Şirket iletişim")]
        public string? Contact { get; set; }

        [Display(Name = "Logo")]
        public IFormFile? UrlAvatar { get; set; }

        [Display(Name = "Konum")]
        public string? Location { get; set; }

        [Display(Name = "Şirket web sitesi")]
        [StringLength(50, ErrorMessage = "Web sitesi 50 karakterden fazla olamaz.")]
        public string? WebsiteURL { get; set; }

        [Display(Name = "Şirket il")]
        public int ProvinceId { get; set; }

        [Display(Name = "Şirket büyüklüğü")]
        public string? CompanySize { get; set; }

        [Display(Name = "Çalışma günleri")]
        public string? WorkingDays { get; set; }

        [Display(Name = "Ülke")]
        public int CountryId { get; set; }

        [Display(Name = "İletişim numarası")]
        [StringLength(20, ErrorMessage = "Lütfen geçerli bir iletişim numarası giriniz.", MinimumLength = 9)]
        public string? Phone { get; set; }

        [Display(Name = "İçerik")]
        public string? Content { get; set; }

    }
}
