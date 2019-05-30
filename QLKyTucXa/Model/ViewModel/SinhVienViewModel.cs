using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class SinhVienViewModel
    {
        public string IDSinhVien { get; set; }
        public byte[] HinhDaiDien { get; set; }
        public string TenSV { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DanToc { get; set; }
        public string QuocTich { get; set; }
        public string IDLop { get; set; }
        public string TrangThaiSV { get; set; }
        public string IDPhong { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}
