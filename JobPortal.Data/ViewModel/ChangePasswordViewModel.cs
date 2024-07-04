using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mevcut şifre")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Yeni şifre")]
        public string NewPassword { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Şifreyi onayla")]
        public string ConfirmPassword { get; set; }
    }
}
