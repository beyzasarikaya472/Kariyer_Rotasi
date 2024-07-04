using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class UpdateCategoryViewModel
    {
        [Required(ErrorMessage = "Lütfen kategori adını giriniz.")]
        [StringLength(100, ErrorMessage = "Kategori adı 100 karakterden fazla olamaz.")]
        public string Name { get; set; }

        [StringLength(256, ErrorMessage = "Açıklama 256 karakterden fazla olamaz.")]
        public string? Description { get; set; }

    }
}
