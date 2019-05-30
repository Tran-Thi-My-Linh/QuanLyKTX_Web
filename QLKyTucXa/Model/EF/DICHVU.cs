namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            CHITIETHOADONPHONGs = new HashSet<CHITIETHOADONPHONG>();
            DICHVUPHONGs = new HashSet<DICHVUPHONG>();
            PHIEUDIENNUOCs = new HashSet<PHIEUDIENNUOC>();
        }

        [Key]
        public int IDDichVu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDichVu { get; set; }

        public double DonGiaDM { get; set; }

        public double DonGiaVuot { get; set; }

        public int MucHoTro { get; set; }

        public bool LoaiDichVu { get; set; }

        public int? SoLuongDM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONPHONG> CHITIETHOADONPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DICHVUPHONG> DICHVUPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDIENNUOC> PHIEUDIENNUOCs { get; set; }
    }
}
