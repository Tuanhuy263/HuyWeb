namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_FOBPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_FOBPayment()
        {
            DIO_OrderChangeAcknowledgmentHeader = new HashSet<DIO_OrderChangeAcknowledgmentHeader>();
            DIO_WHShippingAdviceHeader = new HashSet<DIO_WHShippingAdviceHeader>();
            DIO_WHShippingOrderHeader = new HashSet<DIO_WHShippingOrderHeader>();
            DIO_WSTReceiptAdviceHeader = new HashSet<DIO_WSTReceiptAdviceHeader>();
            DIO_WSTShipmentAdviceHeader = new HashSet<DIO_WSTShipmentAdviceHeader>();
            DIS_Hub = new HashSet<DIS_Hub>();
            DIS_ASN = new HashSet<DIS_ASN>();
            DIS_POHeader = new HashSet<DIS_POHeader>();
            DIO_PTSASN = new HashSet<DIO_PTSASN>();
            DIS_SaleInvoiceHeader = new HashSet<DIS_SaleInvoiceHeader>();
            DIS_SOHeader = new HashSet<DIS_SOHeader>();
        }

        [Key]
        public int FOBPaymentID { get; set; }

        [Required]
        [StringLength(10)]
        public string FOBPaymentCode { get; set; }

        [StringLength(200)]
        public string FOBPaymentName { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentHeader> DIO_OrderChangeAcknowledgmentHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceHeader> DIO_WHShippingAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderHeader> DIO_WHShippingOrderHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceHeader> DIO_WSTReceiptAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceHeader> DIO_WSTShipmentAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Hub> DIS_Hub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_POHeader> DIS_POHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSASN> DIO_PTSASN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceHeader> DIS_SaleInvoiceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader { get; set; }
    }
}
