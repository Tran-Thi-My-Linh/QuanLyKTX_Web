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
            DICHVUPHONGs = new HashSet<DICHVUPHONG>();
            PHIEUDIENNUOCs = new HashSet<PHIEUDIENNUOC>();
            HOADONDICHVUPHONGs = new HashSet<HOADONDICHVUPHONG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDDichVu { get; set; }

        [StringLength(50)]
        public string TenDichVu { get; set; }

        public double? GIaTri { get; set; }

        public bool? BatBuoc { get; set; }

        [StringLength(50)]
        public string LoaiDichVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DICHVUPHONG> DICHVUPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDIENNUOC> PHIEUDIENNUOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONDICHVUPHONG> HOADONDICHVUPHONGs { get; set; }
    }
}
