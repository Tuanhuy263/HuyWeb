namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AllowanceCharge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_AllowanceCharge()
        {
            DIO_HubAllowanceCharge = new HashSet<DIO_HubAllowanceCharge>();
            DIO_HubItemAllowanceCharge = new HashSet<DIO_HubItemAllowanceCharge>();
            DIO_OrderChangeAcknowledgmentDetailAllowanceCharge = new HashSet<DIO_OrderChangeAcknowledgmentDetailAllowanceCharge>();
            DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge = new HashSet<DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge>();
            DIO_OrderChangeRequestDetailAllowanceCharge = new HashSet<DIO_OrderChangeRequestDetailAllowanceCharge>();
            DIO_OrderChangeRequestHeaderAllowanceCharge = new HashSet<DIO_OrderChangeRequestHeaderAllowanceCharge>();
            DIO_QuickBookAllowanceCharge = new HashSet<DIO_QuickBookAllowanceCharge>();
            DIO_PODetailAllowanceCharge = new HashSet<DIO_PODetailAllowanceCharge>();
            DIO_POHeaderAllowanceCharge = new HashSet<DIO_POHeaderAllowanceCharge>();
            DIO_POInvoiceDetailAllowanceCharge = new HashSet<DIO_POInvoiceDetailAllowanceCharge>();
            DIO_POInvoiceHeaderAllowanceCharge = new HashSet<DIO_POInvoiceHeaderAllowanceCharge>();
            DIO_SODetailAllowanceCharge = new HashSet<DIO_SODetailAllowanceCharge>();
            DIO_SOHeaderAllowanceCharge = new HashSet<DIO_SOHeaderAllowanceCharge>();
            DIO_SOInvoiceDetailAllowanceCharge = new HashSet<DIO_SOInvoiceDetailAllowanceCharge>();
            DIO_SOInvoiceHeaderAllowanceCharge = new HashSet<DIO_SOInvoiceHeaderAllowanceCharge>();
        }

        [Key]
        public int AllowanceChargeID { get; set; }

        [Required]
        [StringLength(5)]
        public string AllowanceChargeCode { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsTax { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubAllowanceCharge> DIO_HubAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubItemAllowanceCharge> DIO_HubItemAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentDetailAllowanceCharge> DIO_OrderChangeAcknowledgmentDetailAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge> DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestDetailAllowanceCharge> DIO_OrderChangeRequestDetailAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestHeaderAllowanceCharge> DIO_OrderChangeRequestHeaderAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_QuickBookAllowanceCharge> DIO_QuickBookAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PODetailAllowanceCharge> DIO_PODetailAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POHeaderAllowanceCharge> DIO_POHeaderAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POInvoiceDetailAllowanceCharge> DIO_POInvoiceDetailAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POInvoiceHeaderAllowanceCharge> DIO_POInvoiceHeaderAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SODetailAllowanceCharge> DIO_SODetailAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SOHeaderAllowanceCharge> DIO_SOHeaderAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SOInvoiceDetailAllowanceCharge> DIO_SOInvoiceDetailAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SOInvoiceHeaderAllowanceCharge> DIO_SOInvoiceHeaderAllowanceCharge { get; set; }
    }
}
