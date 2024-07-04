using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class UpdateSkillViewModel
    {
        [Required(ErrorMessage = "Lütfen yetenek adını girin.")]
        [StringLength(50, ErrorMessage = "Yetenek adı 50 karakterden fazla olamaz.")]
        public string Name { get; set; }

    }
}
