namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_VendorPostingGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_VendorPostingGroup()
        {
            DIO_VendorLedgerEntry = new HashSet<DIO_VendorLedgerEntry>();
        }

        [Key]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(10)]
        public string PayableAccountNo { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] UpdateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorLedgerEntry> DIO_VendorLedgerEntry { get; set; }
    }
}
