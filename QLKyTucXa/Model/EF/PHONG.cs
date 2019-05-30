namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            DICHVUPHONGs = new HashSet<DICHVUPHONG>();
            HOADONPHONGs = new HashSet<HOADONPHONG>();
            PHIEUBAOHONGs = new HashSet<PHIEUBAOHONG>();
            PHIEUDIENNUOCs = new HashSet<PHIEUDIENNUOC>();
            PHIEULUUTRUs = new HashSet<PHIEULUUTRU>();
            THIETBIPHONGs = new HashSet<THIETBIPHONG>();
            THUCHIs = new HashSet<THUCHI>();
        }

        [Key]
        [StringLength(5)]
        public string IDPhong { get; set; }

        public int SoLuongToiDa { get; set; }

        public int SoLuongDangO { get; set; }

        [Required]
        [StringLength(5)]
        public string LoaiPhong { get; set; }

        [StringLength(50)]
        public string NguyenVongPhong { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThaiPhong { get; set; }

        public int IDTang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DICHVUPHONG> DICHVUPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONPHONG> HOADONPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUBAOHONG> PHIEUBAOHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDIENNUOC> PHIEUDIENNUOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEULUUTRU> PHIEULUUTRUs { get; set; }

        public virtual TANG TANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THIETBIPHONG> THIETBIPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUCHI> THUCHIs { get; set; }
    }
}
