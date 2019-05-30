namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONPHONG")]
    public partial class HOADONPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONPHONG()
        {
            CHITIETHOADONPHONGs = new HashSet<CHITIETHOADONPHONG>();
        }

        [Column(TypeName = "date")]
        public DateTime NgayLap { get; set; }

        public double TongTien { get; set; }

        public int? IDThuChi { get; set; }

        [Required]
        [StringLength(5)]
        public string IDPhong { get; set; }

        [Key]
        public int IDHoaDon { get; set; }

        [Column(TypeName = "date")]
        public DateTime DinhKi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONPHONG> CHITIETHOADONPHONGs { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual THUCHI THUCHI { get; set; }
    }
}
