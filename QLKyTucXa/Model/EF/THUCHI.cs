namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUCHI")]
    public partial class THUCHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUCHI()
        {
            CHITIETHOADONDDKs = new HashSet<CHITIETHOADONDDK>();
            CHITIETTNXTBs = new HashSet<CHITIETTNXTB>();
            HOADONPHONGs = new HashSet<HOADONPHONG>();
            PHIEUDANGKIs = new HashSet<PHIEUDANGKI>();
        }

        [Key]
        public int IDThuChi { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayThuChi { get; set; }

        public double SoTienThuChi { get; set; }

        public bool HinhThucThuChi { get; set; }

        [StringLength(50)]
        public string NoiDungThuChi { get; set; }

        [Required]
        [StringLength(50)]
        public string IDNguoiDung { get; set; }

        public int IDLoaiThuChi { get; set; }

        public int? IDPhieuDangKi { get; set; }

        [StringLength(5)]
        public string IDPhong { get; set; }

        [StringLength(10)]
        public string IDSinhVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONDDK> CHITIETHOADONDDKs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTNXTB> CHITIETTNXTBs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONPHONG> HOADONPHONGs { get; set; }

        public virtual LOAITHUCHI LOAITHUCHI { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDANGKI> PHIEUDANGKIs { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
