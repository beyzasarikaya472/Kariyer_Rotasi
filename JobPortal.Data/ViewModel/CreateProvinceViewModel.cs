using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class CreateProvinceViewModel
    {
        [Required(ErrorMessage = "Lütfen il adını giriniz")]
        [StringLength(50, ErrorMessage = "İl adı 50 karakterden fazla olamaz.")]
        public string Name { get; set; }

    }
}
