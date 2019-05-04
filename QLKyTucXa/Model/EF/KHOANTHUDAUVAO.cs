namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOANTHUDAUVAO")]
    public partial class KHOANTHUDAUVAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOANTHUDAUVAO()
        {
            KHOANTHUDDKs = new HashSet<KHOANTHUDDK>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDKhoanThu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKhoanThu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOANTHUDDK> KHOANTHUDDKs { get; set; }
    }
}
