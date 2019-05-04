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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPhieuDienNuoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime ThangNamDinhKi { get; set; }

        [Required]
        [StringLength(5)]
        public string IDPhong { get; set; }

        public double? TongTien { get; set; }

        public int? IDDichVu { get; set; }

        public int? SoLuongTieuThu { get; set; }

        public int? SoLuongHoTro { get; set; }

        public double? ThanhTien { get; set; }

        public int? IDDienNuoc { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual DIENNUOC DIENNUOC { get; set; }
    }
}
