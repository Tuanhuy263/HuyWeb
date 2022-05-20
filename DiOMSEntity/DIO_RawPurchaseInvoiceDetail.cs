namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawPurchaseInvoiceDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawPurchaseInvoiceDetail()
        {
            DIO_RawAllowanceChargePIDetail = new HashSet<DIO_RawAllowanceChargePIDetail>();
        }

        [Key]
        public int RawPurchaseInvoiceDetailNo { get; set; }

        public int RawPurchaseInvoiceNo { get; set; }

        public int? LnNo { get; set; }

        public decimal? OriginalPOQty { get; set; }

        [StringLength(50)]
        public string UOM { get; set; }

        public decimal? UnitPrice { get; set; }

        [StringLength(255)]
        public string Relationship { get; set; }

        [StringLength(50)]
        public string BasisOfUnitPriceCode { get; set; }

        [StringLength(255)]
        public string ProductDescription { get; set; }

        public decimal? InvoiceQty { get; set; }

        [StringLength(50)]
        public string Pack { get; set; }

        [StringLength(50)]
        public string ShipmentStatusCode { get; set; }

        public decimal? QtyDifference { get; set; }

        [StringLength(50)]
        public string InnerPack { get; set; }

        [StringLength(255)]
        public string SizeDescription { get; set; }

        [StringLength(50)]
        public string PackSize { get; set; }

        public decimal? RetailPrice { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(50)]
        public string ProductCode1 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(50)]
        public string ProductCode2 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(50)]
        public string ProductCode3 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(50)]
        public string ProductCode4 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(50)]
        public string ProductCode5 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(50)]
        public string ProductCode6 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(50)]
        public string ProductCode7 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(50)]
        public string ProductCode8 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(50)]
        public string ProductCode9 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier10 { get; set; }

        [StringLength(50)]
        public string ProductCode10 { get; set; }

        [StringLength(255)]
        public string ColorDescription { get; set; }

        public decimal? ExtendLineAmount { get; set; }

        [StringLength(255)]
        public string BuyerStoreName { get; set; }

        [StringLength(255)]
        public string BuyerStoreCode { get; set; }

        [StringLength(255)]
        public string BuyerStoreAddress1 { get; set; }

        [StringLength(255)]
        public string BuyerStoreAddress2 { get; set; }

        [StringLength(255)]
        public string BuyerStoreCity { get; set; }

        [StringLength(255)]
        public string BuyerStoreState { get; set; }

        [StringLength(255)]
        public string BuyerStoreZipCode { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(50)]
        public string ItemAllowanceCode1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemAllowanceAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemAllowancePercent1 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceDescription1 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceMethodOfHandling1 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceCode2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemAllowanceAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemAllowancePercent2 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceDescription2 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceMethodOfHandling2 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceCode3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemAllowanceAmount3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemAllowancePercent3 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceDescription3 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceMethodOfHandling3 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceCode4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemAllowanceAmount4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemAllowancePercent4 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceDescription4 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceMethodOfHandling4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemAllowanceRate1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemAllowanceRate2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemAllowanceRate3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemAllowanceRate4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemAllowanceQty1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemAllowanceQty2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemAllowanceQty3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemAllowanceQty4 { get; set; }

        [StringLength(80)]
        public string UserDefined196 { get; set; }

        [StringLength(80)]
        public string UserDefined197 { get; set; }

        [StringLength(50)]
        public string ItemChargeCode1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemChargeAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemChargePercent1 { get; set; }

        [StringLength(50)]
        public string ItemChargeDescription1 { get; set; }

        [StringLength(50)]
        public string ItemChargeMethodOfHandling1 { get; set; }

        [StringLength(50)]
        public string ItemChargeCode2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemChargeAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemChargePercent2 { get; set; }

        [StringLength(50)]
        public string ItemChargeDescription2 { get; set; }

        [StringLength(50)]
        public string ItemChargeMethodOfHandling2 { get; set; }

        [StringLength(50)]
        public string ItemChargeCode3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemChargeAmount3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemChargePercent3 { get; set; }

        [StringLength(50)]
        public string ItemChargeDescription3 { get; set; }

        [StringLength(50)]
        public string ItemChargeMethodOfHandling3 { get; set; }

        [StringLength(50)]
        public string ItemChargeCode4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemChargeAmount4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemChargePercent4 { get; set; }

        [StringLength(50)]
        public string ItemChargeDescription4 { get; set; }

        [StringLength(50)]
        public string ItemChargeMethodOfHandling4 { get; set; }

        [StringLength(50)]
        public string ItemChargeRate1 { get; set; }

        [StringLength(50)]
        public string ItemChargeRate2 { get; set; }

        [StringLength(50)]
        public string ItemChargeRate3 { get; set; }

        [StringLength(50)]
        public string ItemChargeRate4 { get; set; }

        [StringLength(50)]
        public string ItemChargeQty1 { get; set; }

        [StringLength(50)]
        public string ItemChargeQty2 { get; set; }

        [StringLength(50)]
        public string ItemChargeQty3 { get; set; }

        [StringLength(50)]
        public string ItemChargeQty4 { get; set; }

        [StringLength(80)]
        public string UserDefined226 { get; set; }

        [StringLength(80)]
        public string UserDefined227 { get; set; }

        public int? MasterItemID { get; set; }

        public int? PurchaseOrderDetailID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawAllowanceChargePIDetail> DIO_RawAllowanceChargePIDetail { get; set; }

        public virtual DIO_RawPurchaseInvoiceHeader DIO_RawPurchaseInvoiceHeader { get; set; }
    }
}
