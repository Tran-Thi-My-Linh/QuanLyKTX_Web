using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLKyTucXa.Models
{
    public class TraCuuModel
    {
        [Key]
        [StringLength(10)]
        public string IDSinhVien { get; set; }
    }
}