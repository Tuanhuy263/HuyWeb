namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_PODetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_PODetail()
        {
            DIO_AllocatedPOSO = new HashSet<DIO_AllocatedPOSO>();
            DIO_PODetailAllowanceCharge = new HashSet<DIO_PODetailAllowanceCharge>();
            DIO_POPIDetail = new HashSet<DIO_POPIDetail>();
            DIO_POSODetail = new HashSet<DIO_POSODetail>();
            DIO_WSTReceiptAdviceLineItemDetail = new HashSet<DIO_WSTReceiptAdviceLineItemDetail>();
            DIO_WSTShipmentAdviceLineItemDetail = new HashSet<DIO_WSTShipmentAdviceLineItemDetail>();
            DIS_LineItem = new HashSet<DIS_LineItem>();
            DIS_LineItemDetail = new HashSet<DIS_LineItemDetail>();
            DIS_PurchaseInvoiceDetail = new HashSet<DIS_PurchaseInvoiceDetail>();
        }

        [Key]
        public int PODetailNo { get; set; }

        public int PONo { get; set; }

        public int MasterItemID { get; set; }

        public int? UOMCodeBase { get; set; }

        public int? UOMCode { get; set; }

        public decimal? UOMRate { get; set; }

        public int? MarkForStoreID { get; set; }

        public int? LnNo { get; set; }

        public decimal? Qty { get; set; }

        public decimal? QtyReceived { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(4000)]
        public string ProductDescription { get; set; }

        [StringLength(10)]
        public string Size { get; set; }

        public decimal? RetailPrice { get; set; }

        public decimal? MultPriceQty { get; set; }

        [StringLength(10)]
        public string TicketCode { get; set; }

        public decimal? ExtendedLineAmount { get; set; }

        [StringLength(10)]
        public string MerchandiseType { get; set; }

        [StringLength(50)]
        public string Style { get; set; }

        public byte? Status { get; set; }

        public int? TaxID { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? TaxRate { get; set; }

        public decimal? TaxAfterDiscountAmount { get; set; }

        public int? DiscountID { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? DiscountRate { get; set; }

        public decimal? Pack { get; set; }

        public decimal? NoOfInnerPack { get; set; }

        public int? BasisUnitPriceID { get; set; }

        [StringLength(48)]
        public string ProductCode1 { get; set; }

        [StringLength(20)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(48)]
        public string ProductCode2 { get; set; }

        [StringLength(20)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(48)]
        public string ProductCode3 { get; set; }

        [StringLength(20)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(48)]
        public string ProductCode4 { get; set; }

        [StringLength(20)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(48)]
        public string ProductCode5 { get; set; }

        [StringLength(20)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(48)]
        public string ProductCode6 { get; set; }

        [StringLength(20)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(48)]
        public string ProductCode7 { get; set; }

        [StringLength(20)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(48)]
        public string ProductCode8 { get; set; }

        [StringLength(20)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(48)]
        public string ProductCode9 { get; set; }

        [StringLength(20)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(48)]
        public string ProductCode10 { get; set; }

        [StringLength(20)]
        public string ProductCodeQualifier10 { get; set; }

        [StringLength(10)]
        public string SubLineItemNo1 { get; set; }

        public decimal? SubLineItemQuantity1 { get; set; }

        [StringLength(10)]
        public string SubLineItemUOM1 { get; set; }

        public decimal? SubLineItemUnitPrice1 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode1Of1 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode2Of1 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode3Of1 { get; set; }

        [StringLength(10)]
        public string SubLineItemNo2 { get; set; }

        public decimal? SubLineItemQuantity2 { get; set; }

        [StringLength(10)]
        public string SubLineItemUOM2 { get; set; }

        public decimal? SubLineItemUnitPrice2 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode1Of2 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode2Of2 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode3Of2 { get; set; }

        [StringLength(10)]
        public string SubLineItemNo3 { get; set; }

        public decimal? SubLineItemQuantity3 { get; set; }

        [StringLength(10)]
        public string SubLineItemUOM3 { get; set; }

        public decimal? SubLineItemUnitPrice3 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode1Of3 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode2Of3 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode3Of3 { get; set; }

        [StringLength(10)]
        public string SubLineItemNo4 { get; set; }

        public decimal? SubLineItemQuantity4 { get; set; }

        [StringLength(10)]
        public string SubLineItemUOM4 { get; set; }

        public decimal? SubLineItemUnitPrice4 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode1Of4 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode2Of4 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode3Of4 { get; set; }

        [StringLength(10)]
        public string SubLineItemNo5 { get; set; }

        public decimal? SubLineItemQuantity5 { get; set; }

        [StringLength(10)]
        public string SubLineItemUOM5 { get; set; }

        public decimal? SubLineItemUnitPrice5 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode1Of5 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode2Of5 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode3Of5 { get; set; }

        [StringLength(10)]
        public string SubLineItemNo6 { get; set; }

        public decimal? SubLineItemQuantity6 { get; set; }

        [StringLength(10)]
        public string SubLineItemUOM6 { get; set; }

        public decimal? SubLineItemUnitPrice6 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode1Of6 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode2Of6 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode3Of6 { get; set; }

        [StringLength(10)]
        public string SubLineItemNo7 { get; set; }

        public decimal? SubLineItemQuantity7 { get; set; }

        [StringLength(10)]
        public string SubLineItemUOM7 { get; set; }

        public decimal? SubLineItemUnitPrice7 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode1Of7 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode2Of7 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode3Of7 { get; set; }

        [StringLength(10)]
        public string SubLineItemNo8 { get; set; }

        public decimal? SubLineItemQuantity8 { get; set; }

        [StringLength(10)]
        public string SubLineItemUOM8 { get; set; }

        public decimal? SubLineItemUnitPrice8 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode1Of8 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode2Of8 { get; set; }

        [StringLength(15)]
        public string SubLineProductCode3Of8 { get; set; }

        [StringLength(10)]
        public string SubLineItemNo9 { get; set; }

        [StringLength(255)]
        public string QBPODetailNo { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(100)]
        public string QBPODetailDiscountNo { get; set; }

        public DateTime? ShippingDate { get; set; }

        [StringLength(255)]
        public string UserDefined113 { get; set; }

        [StringLength(50)]
        public string ItemChangeType { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyLeftToShipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? NPSOOrderQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceToDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? NPQuantityToCreateRA { get; set; }

        [Column(TypeName = "money")]
        public decimal? AdvicedToDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedQty { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public int? MasterLocationID { get; set; }

        public int? SubCustomerID { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        [Column(TypeName = "money")]
        public decimal? FCLQuantity { get; set; }

        [StringLength(100)]
        public string EDILnNo { get; set; }

        [StringLength(255)]
        public string ColorDescription { get; set; }

        [StringLength(255)]
        public string SizeDescription { get; set; }

        public int? SODetailNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AllocatedPOSO> DIO_AllocatedPOSO { get; set; }

        public virtual DIO_BasisUnitPrice DIO_BasisUnitPrice { get; set; }

        public virtual DIO_Discount DIO_Discount { get; set; }

        public virtual DIO_MarkForStore DIO_MarkForStore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PODetailAllowanceCharge> DIO_PODetailAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POPIDetail> DIO_POPIDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POSODetail> DIO_POSODetail { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceLineItemDetail> DIO_WSTReceiptAdviceLineItemDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceLineItemDetail> DIO_WSTShipmentAdviceLineItemDetail { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_LineItem> DIS_LineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_LineItemDetail> DIS_LineItemDetail { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceDetail> DIS_PurchaseInvoiceDetail { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_POHeader DIS_POHeader { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }
    }
}
