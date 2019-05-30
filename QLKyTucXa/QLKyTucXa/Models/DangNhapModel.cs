using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLKyTucXa.Models
{
    public class DangNhapModel
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Mã số sinh viên:")]
        [Required(ErrorMessage = "Nhập mã số sinh viên")]
        public string IDSinhVien { get; set; }

        [StringLength(8)]
        [Display(Name = "Mật khẩu:")]
        [Required(ErrorMessage = "Nhập mật khẩu")]
        public string MatKhau { get; set; }

        [StringLength(50)]
        public string TrangThaiSV { get; set; }

    }
}