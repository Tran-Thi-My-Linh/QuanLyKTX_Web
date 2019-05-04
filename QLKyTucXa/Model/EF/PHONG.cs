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
            PHIEUBAOHONGs = new HashSet<PHIEUBAOHONG>();
            PHIEULUUTRUs = new HashSet<PHIEULUUTRU>();
            THIETBIPHONGs = new HashSet<THIETBIPHONG>();
        }

        [Key]
        [StringLength(5)]
        public string IDPhong { get; set; }

        [StringLength(5)]
        public string LoaiPhong { get; set; }

        public int? SoLuongToiDa { get; set; }

        public int? SoLuongDangO { get; set; }

        public int? TinhTrang { get; set; }

        [StringLength(50)]
        public string NguyenVongPhong { get; set; }

        public int? IDTang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUBAOHONG> PHIEUBAOHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEULUUTRU> PHIEULUUTRUs { get; set; }

        public virtual TANG TANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THIETBIPHONG> THIETBIPHONGs { get; set; }
    }
}
