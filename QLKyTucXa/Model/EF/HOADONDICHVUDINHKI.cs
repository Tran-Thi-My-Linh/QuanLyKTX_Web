namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONDICHVUDINHKI")]
    public partial class HOADONDICHVUDINHKI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDHoaDonPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        public double? TongTien { get; set; }

        public int? IDThuChi { get; set; }

        [StringLength(5)]
        public string IDPhong { get; set; }
    }
}
