namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOIDUNG")]
    public partial class NGUOIDUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOIDUNG()
        {
            THUCHIs = new HashSet<THUCHI>();
        }

        [Key]
        [StringLength(50)]
        public string IDNguoiDung { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhDaiDien { get; set; }

        [StringLength(50)]
        public string TenNguoiDung { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string QueQuan { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        public bool? TrangThaiNguoiDung { get; set; }

        public int? IDNhomNguoiDung { get; set; }

        public virtual NHOMNGUOIDUNG NHOMNGUOIDUNG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUCHI> THUCHIs { get; set; }
    }
}
