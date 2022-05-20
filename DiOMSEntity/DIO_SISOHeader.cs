namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SISOHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_SISOHeader()
        {
            DIO_SISODetail = new HashSet<DIO_SISODetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int SISOHeaderNo { get; set; }

        public int? SIHeaderNo { get; set; }

        public int? SOHeaderNo { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SISODetail> DIO_SISODetail { get; set; }

        public virtual DIS_SaleInvoiceHeader DIS_SaleInvoiceHeader { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }
    }
}
