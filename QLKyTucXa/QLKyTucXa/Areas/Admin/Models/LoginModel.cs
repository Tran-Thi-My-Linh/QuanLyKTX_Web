using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLKyTucXa.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Tên người dùng không được bỏ trống")]
        public string IDNguoiDung { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được bỏ trống")]
        public string MatKhau { get; set; }

        public bool RememberMe { get; set; }
    }
}