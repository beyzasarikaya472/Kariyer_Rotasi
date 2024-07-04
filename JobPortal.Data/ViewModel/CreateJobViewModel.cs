using JobPortal.Common;
using JobPortal.Data.Entities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class CreateJobViewModel
    {
        [Display(Name = "İsim")]
        [Required(ErrorMessage = "Lütfen ürün adını giriniz.")]
        [StringLength(100, ErrorMessage = "İş adı 100 karakterden fazla olamaz.")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        public string? Description { get; set; }

        [Display(Name = "Tanıtım")]
        public string? Introduce { get; set; }

        [Display(Name = "Hedef Nesne")]
        public string? ObjectTarget { get; set; }

        [Display(Name = "İş Deneyimi")]
        public string? Experience { get; set; }

        [Display(Name = "İl")]
        public int ProvinceId { get; set; }

        [Display(Name = "Çalışma Türü")]
        public int TimeId { get; set; }

        [Display(Name = "Minimum Maaş")]
        [Range(0, int.MaxValue, ErrorMessage = "Lütfen geçerli bir maaş giriniz.")]
        public int? MinSalary { get; set; }

        [Display(Name = "Maksimum Maaş")]
        [Range(1, int.MaxValue, ErrorMessage = "Lütfen geçerli bir maaş giriniz.")]
        public int? MaxSalary { get; set; }

        [Display(Name = "Yetenekler")]
        public List<int> SkillIds { get; set; }

        [Display(Name = "Ünvan")]
        public int TitleId { get; set; }

    }
}