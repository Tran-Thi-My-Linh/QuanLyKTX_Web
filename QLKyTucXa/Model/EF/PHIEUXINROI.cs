namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUXINROI")]
    public partial class PHIEUXINROI
    {
        [Key]
        public int IDPhieuXinRoi { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayXinRoi { get; set; }

        [Required]
        [StringLength(100)]
        public string LyDoRoi { get; set; }

        public bool TrangThai { get; set; }

        public int IDPhieuLuuTru { get; set; }

        public virtual PHIEULUUTRU PHIEULUUTRU { get; set; }
    }
}
