namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CustomerPostingGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_CustomerPostingGroup()
        {
            DIS_Hub = new HashSet<DIS_Hub>();
        }

        [Key]
        public int CustomerPostingGroupID { get; set; }

        public int GLAccountID { get; set; }

        [Required]
        [StringLength(10)]
        public string ReceivableAccountNo { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] UpdateDate { get; set; }

        public virtual DIO_GLAccount DIO_GLAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Hub> DIS_Hub { get; set; }
    }
}
