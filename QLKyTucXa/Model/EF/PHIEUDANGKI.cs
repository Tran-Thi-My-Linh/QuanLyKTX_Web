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
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPhieuDangKi { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IDSinhVien { get; set; }

        public int IDDotDangKy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDangKy { get; set; }

        public int? TrangThai { get; set; }

        public int? NV1 { get; set; }

        public int? NV2 { get; set; }

        public int? NV3 { get; set; }

        public virtual DOTDANGKI DOTDANGKI { get; set; }

        public virtual NGUYENVONG NGUYENVONG { get; set; }

        public virtual NGUYENVONG NGUYENVONG1 { get; set; }

        public virtual NGUYENVONG NGUYENVONG2 { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }

        public virtual TRANGTHAIPHIEUDANGKI TRANGTHAIPHIEUDANGKI { get; set; }
    }
}
