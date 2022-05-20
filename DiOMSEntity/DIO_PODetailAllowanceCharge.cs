namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PODetailAllowanceCharge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PODetailAllowanceCharge()
        {
            DIO_POInvoiceDetailAllowanceCharge = new HashSet<DIO_POInvoiceDetailAllowanceCharge>();
        }

        [Key]
        public int PODetailAllowanceChargeID { get; set; }

        public int PODetailNo { get; set; }

        public int? AllowanceChargeID { get; set; }

        public int? AllowanceChargeHandleID { get; set; }

        public int? Sequence { get; set; }

        public int? Indicator { get; set; }

        public decimal? Amount { get; set; }

        public decimal? Percentage { get; set; }

        public decimal? Rate { get; set; }

        public decimal? Quantity { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(255)]
        public string QBID { get; set; }

        public virtual DIO_AllowanceCharge DIO_AllowanceCharge { get; set; }

        public virtual DIO_AllowanceChargeHandle DIO_AllowanceChargeHandle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POInvoiceDetailAllowanceCharge> DIO_POInvoiceDetailAllowanceCharge { get; set; }

        public virtual DIS_PODetail DIS_PODetail { get; set; }
    }
}
