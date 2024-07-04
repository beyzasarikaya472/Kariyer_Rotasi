using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class UpdateTitleViewModel
    {
        [Required(ErrorMessage = "Lütfen başlık adını girin.")]
        [StringLength(100, ErrorMessage = "Başlık adı 100 karakterden fazla olamaz.")]
        public string Name { get; set; }

    }
}
