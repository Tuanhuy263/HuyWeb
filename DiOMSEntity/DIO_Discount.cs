namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Discount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Discount()
        {
            DIO_LandedCostLineItem = new HashSet<DIO_LandedCostLineItem>();
            DIO_OrderChangeAcknowledgmentDetail = new HashSet<DIO_OrderChangeAcknowledgmentDetail>();
            DIS_HubItem = new HashSet<DIS_HubItem>();
            DIS_PODetail = new HashSet<DIS_PODetail>();
            DIS_PurchaseInvoiceDetail = new HashSet<DIS_PurchaseInvoiceDetail>();
            DIS_SaleInvoiceDetail = new HashSet<DIS_SaleInvoiceDetail>();
            DIS_SODetail = new HashSet<DIS_SODetail>();
            DIS_VendorItem = new HashSet<DIS_VendorItem>();
            DIO_WHStockInDetail = new HashSet<DIO_WHStockInDetail>();
        }

        [Key]
        public int DiscountID { get; set; }

        [Required]
        [StringLength(250)]
        public string DiscountCode { get; set; }

        [StringLength(250)]
        public string DiscountName { get; set; }

        public decimal? DiscountRate { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(250)]
        public string QBID { get; set; }

        public DateTime? QBModified { get; set; }

        public DateTime? LastSyncDate { get; set; }

        [StringLength(255)]
        public string QBAccount { get; set; }

        public int? QBAccountID { get; set; }

        public virtual DIO_QuickBookAccount DIO_QuickBookAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LandedCostLineItem> DIO_LandedCostLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentDetail> DIO_OrderChangeAcknowledgmentDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_HubItem> DIS_HubItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PODetail> DIS_PODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceDetail> DIS_PurchaseInvoiceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceDetail> DIS_SaleInvoiceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SODetail> DIS_SODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_VendorItem> DIS_VendorItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockInDetail> DIO_WHStockInDetail { get; set; }
    }
}
