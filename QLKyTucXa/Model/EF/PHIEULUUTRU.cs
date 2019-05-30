namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEULUUTRU")]
    public partial class PHIEULUUTRU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEULUUTRU()
        {
            PHIEUXINROIs = new HashSet<PHIEUXINROI>();
        }

        [Key]
        public int IDPhieuLuuTru { get; set; }

        [Required]
        [StringLength(10)]
        public string IDSinhVien { get; set; }

        [Required]
        [StringLength(5)]
        public string IDPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKetThuc { get; set; }

        public bool? TrangThai { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUXINROI> PHIEUXINROIs { get; set; }
    }
}
