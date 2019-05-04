namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAPXUATTHIETBI")]
    public partial class PHIEUNHAPXUATTHIETBI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHAPXUATTHIETBI()
        {
            CHITIETTNXTBs = new HashSet<CHITIETTNXTB>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPhieuNhapXuat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhapXuat { get; set; }

        [StringLength(50)]
        public string NhanVienNhap { get; set; }

        public double? TongTien { get; set; }

        public int? IDThuChi { get; set; }

        [StringLength(10)]
        public string LoaiNhapXuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTNXTB> CHITIETTNXTBs { get; set; }

        public virtual THUCHI THUCHI { get; set; }
    }
}
