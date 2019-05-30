namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            PHIEUDANGKIs = new HashSet<PHIEUDANGKI>();
            PHIEULUUTRUs = new HashSet<PHIEULUUTRU>();
        }

        [Key]
        [StringLength(10)]
        public string IDSinhVien { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhDaiDien { get; set; }

        [StringLength(60)]
        public string TenSV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string QueQuan { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(30)]
        public string DanToc { get; set; }

        [StringLength(50)]
        public string QuocTich { get; set; }

        [StringLength(10)]
        public string IDLop { get; set; }

        public int? IDUuTien { get; set; }

        [StringLength(50)]
        public string TrangThaiSV { get; set; }

        [StringLength(8)]
        public string MatKhau { get; set; }

        public int? NV1 { get; set; }

        public int? NV2 { get; set; }

        public int? NV3 { get; set; }

        public virtual LOP LOP { get; set; }

        public virtual NGUYENVONG NGUYENVONG { get; set; }

        public virtual NGUYENVONG NGUYENVONG1 { get; set; }

        public virtual NGUYENVONG NGUYENVONG2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDANGKI> PHIEUDANGKIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEULUUTRU> PHIEULUUTRUs { get; set; }

        public virtual UUTIEN UUTIEN { get; set; }
    }
}
