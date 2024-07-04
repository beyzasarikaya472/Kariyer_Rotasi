using JobPortal.Data.Entities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class ListEmployersViewWModel
    {
        public Guid? Id { get; set; }
        [Display(Name = "Tam Ad")]
        public string? FullName { get; set; }
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
        [Display(Name = "İletişim")]
        public string? Contact { get; set; }
        [Display(Name = "Logo")]
        public string? UrlAvatar { get; set; }
        [Display(Name = "Konum")]
        public string? Location { get; set; }
        [Display(Name = "Web Sitesi")]
        public string? WebsiteURL { get; set; }
        public int? Status { get; set; }
        [Display(Name = "Kayıt Tarihi")]
        public DateTime? RegisterDate { get; set; }
        [Display(Name = "İl")]
        public string? ProvinceName { get; set; }

    }
}
