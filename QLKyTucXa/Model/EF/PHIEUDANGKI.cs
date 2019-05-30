namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDANGKI")]
    public partial class PHIEUDANGKI
    {
        [Key]
        public int IDPhieuDangKi { get; set; }

        [Required]
        [StringLength(10)]
        public string IDSinhVien { get; set; }

        public int IDDotDangKy { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDangKy { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThaiPDK { get; set; }

        public int? IDThuChi { get; set; }

        public virtual DOTDANGKI DOTDANGKI { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }

        public virtual THUCHI THUCHI { get; set; }
    }
}
