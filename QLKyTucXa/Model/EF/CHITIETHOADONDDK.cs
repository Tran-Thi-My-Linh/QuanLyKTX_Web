namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADONDDK")]
    public partial class CHITIETHOADONDDK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDKhoanThuDDK { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDHoaDonDDK { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual HOADONDDK HOADONDDK { get; set; }

        public virtual KHOANTHUDDK KHOANTHUDDK { get; set; }
    }
}
