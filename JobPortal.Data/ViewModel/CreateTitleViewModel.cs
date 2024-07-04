using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class CreateTitleViewModel
    {
        [Required(ErrorMessage = "Lütfen ünvan adını giriniz")]
        [StringLength(100, ErrorMessage = "Ünvan adı 100 karakterden fazla olamaz.")]
        public string Name { get; set; }

    }
}
