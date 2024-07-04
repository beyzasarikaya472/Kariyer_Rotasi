using JobPortal.Data.Entities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class CreateBlogViewModel
    {
        [Display(Name = "Yazar")]
        [StringLength(50, ErrorMessage = "Yazar 100 karakterden fazla olamaz.")]
        [Required(ErrorMessage = "Lütfen yazar adını giriniz.")]
        public string Author { get; set; }
        [Display(Name = "Başlık")]
        [StringLength(100, ErrorMessage = "Başlık 100 karakterden uzun olamaz.")]
        [Required(ErrorMessage = "Lütfen blogun başlığını girin.")]
        public string Title { get; set; }
        [Display(Name = "İçerik")]
        public string? Content { get; set; }
        [Display(Name = "Resim")]
        public IFormFile? Image { get; set; }
        [Display(Name = "Bloga genel bakış")]
        public string? Description { get; set; }
    }
}