using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class UpdateBlogViewModel
    {
        [Display(Name = "Yazar")]
        [StringLength(50, ErrorMessage = "Yazar adı 50 karakterden fazla olamaz.")]
        [Required(ErrorMessage = "Lütfen yazar adını giriniz.")]
        public string Author { get; set; }

        [Display(Name = "Başlık")]
        [StringLength(100, ErrorMessage = "Başlık 100 karakterden fazla olamaz.")]
        [Required(ErrorMessage = "Lütfen blog başlığını giriniz.")]
        public string Title { get; set; }

        [Display(Name = "İçerik")]
        public string? Content { get; set; }

        [Display(Name = "Blog Özeti")]
        public string? Description { get; set; }

    }
}