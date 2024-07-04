using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class CreateCategoryViewModel
    {
        [Required(ErrorMessage = "Lütfen kategori adını girin")]
        [StringLength(100, ErrorMessage = "Kategori adı 100 karakterden uzun olamaz.")]
        public string Name { get; set; }
        [StringLength(256, ErrorMessage = "Açıklama 256 karakterden fazla olamaz.")]
        public string? Description { get; set; }
    }
}
