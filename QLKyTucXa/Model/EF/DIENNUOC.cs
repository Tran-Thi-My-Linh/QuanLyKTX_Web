namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIENNUOC")]
    public partial class DIENNUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIENNUOC()
        {
            PHIEUDIENNUOCs = new HashSet<PHIEUDIENNUOC>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDDienNuoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        public int? SoLuongDinhMuc { get; set; }

        public int? DonGiaDinhMuc { get; set; }

        public double? DonGiaVuot { get; set; }

        public double? SoLuongHoTro { get; set; }

        public double? LoaiDienNuoc { get; set; }

        public bool? DangApDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDIENNUOC> PHIEUDIENNUOCs { get; set; }
    }
}
