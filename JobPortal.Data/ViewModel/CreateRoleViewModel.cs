using System.ComponentModel.DataAnnotations;

namespace JobPortal.Data.ViewModel
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Rol")]
        public string RoleName { get; set; }
        [Required]
        [Display(Name = "Açıklama")]
        public string RoleDescription { get; set; }
    }
}