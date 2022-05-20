namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Freight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Freight()
        {
            DIO_InvoicePOFreight = new HashSet<DIO_InvoicePOFreight>();
            DIO_InvoiceSOFreight = new HashSet<DIO_InvoiceSOFreight>();
            DIO_OrderChangeAcknowledgmentFreight = new HashSet<DIO_OrderChangeAcknowledgmentFreight>();
            DIO_POFreight = new HashSet<DIO_POFreight>();
            DIO_SOFreight = new HashSet<DIO_SOFreight>();
            DIO_HubFreight = new HashSet<DIO_HubFreight>();
            DIO_StockInFreight = new HashSet<DIO_StockInFreight>();
            DIO_VendorFreight = new HashSet<DIO_VendorFreight>();
        }

        [Key]
        public int FreightID { get; set; }

        [Required]
        [StringLength(20)]
        public string FreightCode { get; set; }

        [Required]
        [StringLength(250)]
        public string FreightName { get; set; }

        public decimal? Amount { get; set; }

        public byte DistributedMethod { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InvoicePOFreight> DIO_InvoicePOFreight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InvoiceSOFreight> DIO_InvoiceSOFreight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentFreight> DIO_OrderChangeAcknowledgmentFreight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POFreight> DIO_POFreight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SOFreight> DIO_SOFreight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubFreight> DIO_HubFreight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockInFreight> DIO_StockInFreight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorFreight> DIO_VendorFreight { get; set; }
    }
}
