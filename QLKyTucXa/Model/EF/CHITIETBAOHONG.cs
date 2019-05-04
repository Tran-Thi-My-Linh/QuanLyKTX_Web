namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETBAOHONG")]
    public partial class CHITIETBAOHONG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDBaoHong { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDThietBi { get; set; }

        public int? SoLuong { get; set; }

        public int? KhongTheSua { get; set; }

        public int? CoTheSua { get; set; }

        public int? SuaThanhCong { get; set; }

        public int? SuaThatBai { get; set; }

        public virtual PHIEUBAOHONG PHIEUBAOHONG { get; set; }

        public virtual THIETBI THIETBI { get; set; }
    }
}
