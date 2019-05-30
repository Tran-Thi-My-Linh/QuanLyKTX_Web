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
        public int IDThuChi { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDKhoanThuDDK { get; set; }

        public double ThanhTien { get; set; }

        public virtual KHOANTHUDDK KHOANTHUDDK { get; set; }

        public virtual THUCHI THUCHI { get; set; }
    }
}
