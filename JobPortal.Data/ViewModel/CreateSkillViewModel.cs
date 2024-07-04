using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class CreateSkillViewModel
    {
        [Required(ErrorMessage = "Lütfen yetenek adını giriniz")]
        [StringLength(50, ErrorMessage = "Yetenek adı 50 karakterden fazla olamaz.")]
        public string Name { get; set; }

        [Display(Name = "Yetenek logosu")]
        [Required(ErrorMessage = "Lütfen yetenek logosunu giriniz")]
        public IFormFile Logo { get; set; }

    }
}
