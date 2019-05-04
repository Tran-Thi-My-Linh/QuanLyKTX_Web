namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUCHI")]
    public partial class THUCHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUCHI()
        {
            HOADONDDKs = new HashSet<HOADONDDK>();
            PHIEUNHAPXUATTHIETBIs = new HashSet<PHIEUNHAPXUATTHIETBI>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDThuChi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThuChi { get; set; }

        public double? SoTienThuChi { get; set; }

        public bool? HinhThucThuChi { get; set; }

        [StringLength(50)]
        public string NoiDungThuChi { get; set; }

        [StringLength(50)]
        public string IDNhanVienThuChi { get; set; }

        public int? IDLoaiThuChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONDDK> HOADONDDKs { get; set; }

        public virtual LOAITHUCHI LOAITHUCHI { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAPXUATTHIETBI> PHIEUNHAPXUATTHIETBIs { get; set; }
    }
}
