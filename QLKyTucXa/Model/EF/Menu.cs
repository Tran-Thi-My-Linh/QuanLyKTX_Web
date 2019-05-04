namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        [Key]
        public int IDMenu { get; set; }

        [StringLength(50)]
        public string TenMenu { get; set; }

        [StringLength(50)]
        public string Link { get; set; }

        public int? ThuTuHienThi { get; set; }

        public bool? TrangThai { get; set; }

        public int? LoaiMenu { get; set; }

        public int? MenuCha { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }

        [StringLength(50)]
        public string ThuocTinh { get; set; }
    }
}
