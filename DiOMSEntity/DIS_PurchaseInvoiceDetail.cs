namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_PurchaseInvoiceDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_PurchaseInvoiceDetail()
        {
            DIO_POInvoiceDetailAllowanceCharge = new HashSet<DIO_POInvoiceDetailAllowanceCharge>();
            DIO_POPIDetail = new HashSet<DIO_POPIDetail>();
            DIO_PurchaseInvoiceBatch = new HashSet<DIO_PurchaseInvoiceBatch>();
            DIO_PurchaseInvoiceSerial = new HashSet<DIO_PurchaseInvoiceSerial>();
        }

        [Key]
        public int PurchaseInvoiceDetailNo { get; set; }

        public int PurchaseInvoiceNo { get; set; }

        public int LnNo { get; set; }

        public int? UOMCodeBase { get; set; }

        public int? UOMCode { get; set; }

        public decimal? UOMRate { get; set; }

        public int MasterItemID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? UnitPrice { get; set; }

        [StringLength(3)]
        public string BasicUnitPrice { get; set; }

        public decimal? UnitCost { get; set; }

        public decimal? Amount { get; set; }

        public int? TaxID { get; set; }

        public decimal? TaxRate { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? TaxAfterDiscountAmount { get; set; }

        public decimal? ReceiveWithoutUnReceipt { get; set; }

        public byte? Status { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? DiscountID { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? DiscountRate { get; set; }

        [StringLength(255)]
        public string QBPIDetailNo { get; set; }

        public int? PurchaseOrderDetailID { get; set; }

        public int? PODetailNo { get; set; }

        public int? MasterLocationID { get; set; }

        public virtual DIO_Discount DIO_Discount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POInvoiceDetailAllowanceCharge> DIO_POInvoiceDetailAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POPIDetail> DIO_POPIDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PurchaseInvoiceBatch> DIO_PurchaseInvoiceBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PurchaseInvoiceSerial> DIO_PurchaseInvoiceSerial { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_PODetail DIS_PODetail { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIS_PurchaseInvoiceHeader DIS_PurchaseInvoiceHeader { get; set; }
    }
}
