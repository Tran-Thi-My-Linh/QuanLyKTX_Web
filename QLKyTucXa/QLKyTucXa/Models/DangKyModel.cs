using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKyTucXa.Models
{
    public class DangKyModel
    {

        [Key]        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDPhieuDangKi { get; set; }


        [Required(ErrorMessage = "Chọn đợt đăng ký")]
        [Display(Name = "Đợt đăng ký")]
        public int IDDotDangKy { get; set; }

        //[Column(TypeName = "date")]
        //[Display(Name = "Ngày đăng ký")]
        //[Required(ErrorMessage = "Nhập ngày đăng ký")]
        //public DateTime? NgayDangKy { get; set; }

       
        [StringLength(10)]
        [Required(ErrorMessage = "Nhập mã sinh viên")]
        [Display(Name = "Mã sinh viên")]
        public string IDSinhVien { get; set; }



        [Display(Name = "Hình đại diện")]
        [Required(ErrorMessage = "Chọn hình sinh viên")]
        public byte[] HinhDaiDien { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Nhập họ tên sinh viên")]
        [Display(Name = "Họ và tên")]
        public string TenSV { get; set; }

        [Column(TypeName = "date")]
        [Required(ErrorMessage = "Nhập ngày sinh")]
        [Display(Name = "Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        [StringLength(5)]
        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Chọn giới tính sinh viên")]
        public string GioiTinh { get; set; }

        public static IEnumerable<SelectListItem> GetGenderSelectItems()
        {
            yield return new SelectListItem { Text = "Nam", Value = "Nam" };
            yield return new SelectListItem { Text = "Nữ", Value = "Nữ" };
        }

        [StringLength(50)]
        [Required(ErrorMessage = "Nhập quê quán")]
        [Display(Name = "Quê quán")]
        public string QueQuan { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Nhập số điện thoại")]
        [Display(Name = "Điện thoại")]
        public string SDT { get; set; }

        [Display(Name = "Quốc tịch")]
        [Required(ErrorMessage = "Nhập quốc tịch")]
        [StringLength(50)]
        public string QuocTich { get; set; }

        [StringLength(100)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Nhập Email")]
        public string Email { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Chọn dân tộc")]
        [Display(Name = "Dân tộc")]
        public string DanToc { get; set; }

       
        [StringLength(10)]
        [Display(Name = "Lớp")]
        [Required(ErrorMessage = "Nhập lớp")]
        public string IDLop { get; set; }


        [Display(Name = "Nguyện vọng 1")]
        [Required(ErrorMessage = "Chọn nguyện vọng 1")]
        public int NV1 { get; set; }

        [Display(Name = "Nguyện vọng 2")]
        [Required(ErrorMessage = "Chọn nguyện vọng 2")]
        public int NV2 { get; set; }


        [Display(Name = "Nguyện vọng 3")]
        [Required(ErrorMessage = "Chọn nguyện vọng 3")]
        public int NV3 { get; set; }

        [Display(Name = "Ưu tiên")]
        [Required(ErrorMessage = "Chọn ưu tiên")]
        public int IDUuTien { get; set; }

        
    }
}
