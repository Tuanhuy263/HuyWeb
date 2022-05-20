namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_POPIHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_POPIHeader()
        {
            DIO_POPIDetail = new HashSet<DIO_POPIDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int POPIHeaderID { get; set; }

        public int? POHeaderNo { get; set; }

        public int? PIHeaderNo { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POPIDetail> DIO_POPIDetail { get; set; }

        public virtual DIS_PurchaseInvoiceHeader DIS_PurchaseInvoiceHeader { get; set; }

        public virtual DIS_POHeader DIS_POHeader { get; set; }
    }
}
