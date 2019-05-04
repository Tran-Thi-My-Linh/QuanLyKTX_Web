namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONDDK")]
    public partial class HOADONDDK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONDDK()
        {
            CHITIETHOADONDDKs = new HashSet<CHITIETHOADONDDK>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDHoaDon { get; set; }

        public int? IDPhieuDangKi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        public double? TongTien { get; set; }

        public int? IDThuChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONDDK> CHITIETHOADONDDKs { get; set; }

        public virtual THUCHI THUCHI { get; set; }
    }
}
