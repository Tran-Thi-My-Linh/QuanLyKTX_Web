namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUBAOHONG")]
    public partial class PHIEUBAOHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUBAOHONG()
        {
            CHITIETBAOHONGs = new HashSet<CHITIETBAOHONG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDBaoHong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBaoHong { get; set; }

        public int? TongSoLuong { get; set; }

        [Required]
        [StringLength(5)]
        public string IDPhong { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBAOHONG> CHITIETBAOHONGs { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
