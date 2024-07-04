using System.ComponentModel.DataAnnotations;

namespace JobPortal.Data.ViewModel
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
        public Guid Id { get; set; }
        [Display(Name = "Rol")]
        [Required(ErrorMessage = "Rol Adı zorunludur.")]
        public string RoleName { get; set; }
        [Display(Name = "Açıklama")]
        [StringLength(256, ErrorMessage = "Açıklama 256 karakterden fazla olamaz.")]
        public string RoleDescription { get; set; }
        public List<string> Users { get; set; }

    }
}
