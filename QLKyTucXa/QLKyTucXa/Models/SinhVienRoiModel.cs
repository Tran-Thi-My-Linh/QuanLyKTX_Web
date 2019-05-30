using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLKyTucXa.Models
{
    public class SinhVienRoiModel
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDPhieuXinRoi { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Nhập mã sinh viên")]
        [Display(Name = "Mã sinh viên")]
        public string IDSinhVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayXinRoi { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name ="Lý do")]
        public string LyDoRoi { get; set; }

        public int IDPhieuLuuTru { get; set; }
    }
}