using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class UpdateProvinceViewModel
    {
        [Required(ErrorMessage = "Lütfen il adını girin.")]
        [StringLength(50, ErrorMessage = "İl adı 50 karakterden fazla olamaz.")]
        public string Name { get; set; }

    }
}
