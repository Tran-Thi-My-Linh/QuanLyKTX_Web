namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOTDANGKI")]
    public partial class DOTDANGKI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOTDANGKI()
        {
            KHOANTHUDDKs = new HashSet<KHOANTHUDDK>();
            PHIEUDANGKIs = new HashSet<PHIEUDANGKI>();
        }

        [Key]
        public int IDDotDangKi { get; set; }

        [StringLength(30)]
        public string TenDotDangKi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        public int? ChiTieuNam { get; set; }

        public int? ChiTieuNu { get; set; }

        public int? TongChiTieu { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOANTHUDDK> KHOANTHUDDKs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDANGKI> PHIEUDANGKIs { get; set; }
    }
}
