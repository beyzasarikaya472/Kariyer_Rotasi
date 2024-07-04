using JobPortal.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class CVsViewModel
    {
        //List CVs
        public int CVId { get; set; }
        [Display(Name = "Sertifika")]
        public string Certificate { get; set; }
        [Display(Name = "Ana Dal")]
        public string Major { get; set; }
        [Display(Name = "Başvuru Tarihi")]
        public DateTime ApplyDate { get; set; }
        [Display(Name = "Mezuniyet Yeri")]
        public string GraduatedAt { get; set; }
        [Display(Name = "GPA")]
        public float GPA { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Tanıtım")]
        public string Introduce { get; set; }
        public Guid UserId { get; set; }
        [Display(Name = "Başvuran Adı")]
        public string UserName { get; set; }
        public int CVStatus { get; set; } // = 0 reddedildi // = 1 bekliyor // = 2 kabul edildi // = 3 zaten geri bildirim yapıldı // = -1 iptal
        [Display(Name = "İş Adı")]
        public string JobName { get; set; }
        [Display(Name = "Logo")]
        public string EmployerLogo { get; set; }
        public Guid EmployerId { get; set; }
        [Display(Name = "CV")]
        public string CVImage { get; set; }
        [Display(Name = "Telefon")]
        public string CVPhone { get; set; }
        [Display(Name = "E-posta")]
        public string CVEmail { get; set; }

        // Geri Bildirim
        [Display(Name = "Adres")]
        public string? EmployerAddress { get; set; }
        [Display(Name = "Telefon")]
        [StringLength(20, ErrorMessage = "Lütfen geçerli bir telefon numarası giriniz.", MinimumLength = 9)]
        public string? EmployerPhone { get; set; }
        [Display(Name = "Yorum")]
        public string? EmployerComment { get; set; }
        [Display(Name = "Puan")]
        [Range(0, 10, ErrorMessage = "Lütfen geçerli bir puan giriniz (0-10).")]
        public byte? EmployerRating { get; set; }
        [Display(Name = "Şehir")]
        [StringLength(30, ErrorMessage = "Şehir adı 30 karakterden fazla olamaz.")]
        public string? EmployerCity { get; set; }
        [Display(Name = "E-posta")]
        [StringLength(50, ErrorMessage = "E-posta adresi 50 karakterden fazla olamaz.")]
        public string? EmployerEmail { get; set; }
        public DateTime? CommentOn { get; set; }

    }
}
