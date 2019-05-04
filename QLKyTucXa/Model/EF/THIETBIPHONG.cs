namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THIETBIPHONG")]
    public partial class THIETBIPHONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string IDPhong { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDThietBi { get; set; }

        public int? SoLuong { get; set; }

        public int? HuHong { get; set; }

        public int? DangSuaChua { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual THIETBI THIETBI { get; set; }
    }
}
