using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "EMAİL")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "ŞİFRE")]
        public string Password { get; set; }
        [Display(Name = "HATIRLA")]
        public bool RememberMe { get; set; }
    }
}
