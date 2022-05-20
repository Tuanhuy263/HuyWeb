namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ASNInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ASNInvoice()
        {
            DIO_ASNInvoiceDetail = new HashSet<DIO_ASNInvoiceDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ASNInvoiceID { get; set; }

        public int? ASNNo { get; set; }

        public int? InvoiceNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_SaleInvoiceHeader DIS_SaleInvoiceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ASNInvoiceDetail> DIO_ASNInvoiceDetail { get; set; }
    }
}
