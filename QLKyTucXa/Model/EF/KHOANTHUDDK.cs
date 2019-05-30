namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOANTHUDDK")]
    public partial class KHOANTHUDDK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOANTHUDDK()
        {
            CHITIETHOADONDDKs = new HashSet<CHITIETHOADONDDK>();
        }

        [Key]
        public int IDKhoanThuDDK { get; set; }

        public int IDKhoanThu { get; set; }

        public int IDDotDangKi { get; set; }

        public double GiaTri { get; set; }

        public bool BatBuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONDDK> CHITIETHOADONDDKs { get; set; }

        public virtual DOTDANGKI DOTDANGKI { get; set; }

        public virtual KHOANTHUDAUVAO KHOANTHUDAUVAO { get; set; }
    }
}
