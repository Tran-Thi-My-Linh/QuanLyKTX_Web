namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDIENNUOC")]
    public partial class PHIEUDIENNUOC
    {
        [Key]
        public int IDPhieuDienNuoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime ThangNamGhiSo { get; set; }

        public int CSCCu { get; set; }

        public int CSCMoi { get; set; }

        public int SoLuongTieuThu { get; set; }

        public int MucHoTro { get; set; }

        public int SoLuongHoTro { get; set; }

        public double DonGiaDM { get; set; }

        public double DonGiaVuot { get; set; }

        public double ThanhTien { get; set; }

        public int IDDichVu { get; set; }

        [Required]
        [StringLength(5)]
        public string IDPhong { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
