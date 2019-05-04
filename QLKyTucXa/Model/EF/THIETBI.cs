namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THIETBI")]
    public partial class THIETBI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THIETBI()
        {
            CHITIETBAOHONGs = new HashSet<CHITIETBAOHONG>();
            CHITIETTNXTBs = new HashSet<CHITIETTNXTB>();
            THIETBIPHONGs = new HashSet<THIETBIPHONG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDThietBi { get; set; }

        [StringLength(30)]
        public string TenThietBi { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhMinhHoa { get; set; }

        public double? GiaTri { get; set; }

        public int? TongSoLuong { get; set; }

        public int? SoLuongTon { get; set; }

        public int? SoLuongPhanBo { get; set; }

        public int? SoLuongHong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBAOHONG> CHITIETBAOHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTNXTB> CHITIETTNXTBs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THIETBIPHONG> THIETBIPHONGs { get; set; }
    }
}
