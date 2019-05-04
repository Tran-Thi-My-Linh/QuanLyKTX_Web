using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLKyTucXa.Areas.Admin.Models
{
    public class BaiVietModel
    {
        [Key]
        public int IDBaiViet { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được bỏ trống")]
        [Display(Name ="Tiêu đề")]
        [StringLength(100)]
        public string TieuDe { get; set; }

        [Required(ErrorMessage = "Nội dung không được bỏ trống")]
        [Display(Name = "Nội dung")]
        [Column(TypeName = "text")]
        public string NoiDung { get; set; }

        [Required(ErrorMessage = "Chọn hình ảnh")]
        [Display(Name = "Hình ảnh")]
        [StringLength(50)]
        public string HinhAnh { get; set; }

        [Required(ErrorMessage = "Ngày tạo không được bỏ trống")]
        [Display(Name = "Ngày tạo")]
        [Column(TypeName = "date")]
        public DateTime NgayTao { get; set; }
    }
}