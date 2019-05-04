namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAIVIET")]
    public partial class BAIVIET
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDBaiViet { get; set; }

        [StringLength(200)]
        public string TieuDe { get; set; }

        [Column(TypeName = "text")]
        public string NoiDung { get; set; }

        [StringLength(50)]
        public string HinhAnh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }
    }
}
