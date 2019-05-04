namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVUPHONG")]
    public partial class DICHVUPHONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string IDPhong { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDDichVu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDangKi { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        public virtual DICHVU DICHVU { get; set; }
    }
}
