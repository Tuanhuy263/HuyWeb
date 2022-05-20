namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_OrderChangeAcknowledgmentDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_OrderChangeAcknowledgmentDetail()
        {
            DIO_OrderChangeAcknowledgmentDetailAllowanceCharge = new HashSet<DIO_OrderChangeAcknowledgmentDetailAllowanceCharge>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column("_SODetailFather")]
        public int? C_SODetailFather { get; set; }

        [StringLength(300)]
        public string GiftWrappingCode { get; set; }

        [StringLength(250)]
        public string LineInstruction { get; set; }

        [StringLength(250)]
        public string GiftMessage { get; set; }

        [StringLength(50)]
        public string ColorDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocationQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? CanceledQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Size { get; set; }

        [StringLength(250)]
        public string FutureUse114 { get; set; }

        [StringLength(250)]
        public string FutureUse184 { get; set; }

        [StringLength(250)]
        public string FutureUse189 { get; set; }

        [StringLength(255)]
        public string ItemDepartNo { get; set; }

        [StringLength(255)]
        public string ItemDepartName { get; set; }

        [Key]
        public int SODetailNo { get; set; }

        public int? ParentSODetailNo { get; set; }

        [StringLength(255)]
        public string EDIItemDescription { get; set; }

        [StringLength(255)]
        public string ProductCode1 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(255)]
        public string ProductCode2 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(255)]
        public string ProductCode3 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(255)]
        public string ProductCode4 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(255)]
        public string ProductCode5 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(255)]
        public string ProductCode6 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(255)]
        public string ProductCode7 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(255)]
        public string ProductCode8 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(255)]
        public string ProductCode9 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(255)]
        public string ProductCode10 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier10 { get; set; }

        [StringLength(255)]
        public string BuyerCode { get; set; }

        [StringLength(255)]
        public string UserDefined113 { get; set; }

        [StringLength(255)]
        public string EDILineNumber { get; set; }

        public double? GSTAmount { get; set; }

        public double? HSTSalesTaxAmount { get; set; }

        [StringLength(30)]
        public string HSTSalesTaxID { get; set; }

        public double? InnerPackNo { get; set; }

        [StringLength(30)]
        public string InvoiceGSTTaxID { get; set; }

        [StringLength(50)]
        public string ItemChangeType { get; set; }

        public double? ItemNoPerPack { get; set; }

        [StringLength(80)]
        public string MechandiseType { get; set; }

        [Column(TypeName = "money")]
        public decimal? MultPriceQty { get; set; }

        public int? LnNo { get; set; }

        [StringLength(100)]
        public string EDILnNo { get; set; }

        [StringLength(2)]
        public string QtyUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyLeftToShipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyLeftToRecieved { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemOrderedQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? DropshipedQty { get; set; }

        public int? ShippingSpeed { get; set; }

        [Column(TypeName = "money")]
        public decimal? OriginalQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? GroceryPackWeigh { get; set; }

        [Column(TypeName = "money")]
        public decimal? GroceryPackVolume { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyShipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyShippedBase { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyShippedByDropship { get; set; }

        [Column(TypeName = "money")]
        public decimal? MasterKitQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? MasterKitQtyShipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? RetailPrice { get; set; }

        [StringLength(30)]
        public string TicketCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChangedUnitPrice { get; set; }

        public double? ASQ { get; set; }

        public byte? Status { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxAfterDiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pack { get; set; }

        [Column(TypeName = "money")]
        public decimal? NoOfInnerPack { get; set; }

        [StringLength(50)]
        public string ItemStatusCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemChangedQuantity { get; set; }

        [StringLength(100)]
        public string QBSODetailNo { get; set; }

        [StringLength(100)]
        public string QBSODetailDiscountNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemCommissionRate { get; set; }

        [StringLength(100)]
        public string QBMasterSODetailNo { get; set; }

        [StringLength(100)]
        public string QBSODetailTaxNo { get; set; }

        public DateTime? ShippingDate { get; set; }

        [StringLength(255)]
        public string SizeDescription { get; set; }

        [StringLength(255)]
        public string SubLineItemNo1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity1 { get; set; }

        [StringLength(255)]
        public string SubLineUOM1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice1 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of1 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of1 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of1 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity2 { get; set; }

        [StringLength(255)]
        public string SubLineUOM2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice2 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of2 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of2 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of2 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity3 { get; set; }

        [StringLength(255)]
        public string SubLineUOM3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice3 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of3 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of3 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of3 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity4 { get; set; }

        [StringLength(255)]
        public string SubLineUOM4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice4 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of4 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of4 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of4 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity5 { get; set; }

        [StringLength(255)]
        public string SubLineUOM5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice5 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of5 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of5 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of5 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity6 { get; set; }

        [StringLength(255)]
        public string SubLineUOM6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice6 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of6 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of6 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of6 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity7 { get; set; }

        [StringLength(255)]
        public string SubLineUOM7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice7 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of7 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of7 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of7 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity8 { get; set; }

        [StringLength(255)]
        public string SubLineUOM8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice8 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of8 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of8 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of8 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo9 { get; set; }

        [StringLength(100)]
        public string ShippingAccount { get; set; }

        [StringLength(100)]
        public string AdditionalRoutingDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAllowance { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCharge { get; set; }

        [StringLength(255)]
        public string DeptNo { get; set; }

        [StringLength(255)]
        public string DeptName { get; set; }

        [StringLength(50)]
        public string ItemACKUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemACKQuantity { get; set; }

        [StringLength(50)]
        public string ItemOrderedUOM { get; set; }

        [StringLength(255)]
        public string ERPItemCode { get; set; }

        [StringLength(50)]
        public string UPCCode { get; set; }

        [StringLength(50)]
        public string UPCQualifier { get; set; }

        [StringLength(50)]
        public string BuyerItemQualifier { get; set; }

        [StringLength(50)]
        public string BuyerItemNo { get; set; }

        [StringLength(50)]
        public string VendorItemQualifier { get; set; }

        [StringLength(50)]
        public string VendorItemNo { get; set; }

        [StringLength(255)]
        public string SKU { get; set; }

        [StringLength(255)]
        public string ItemValue { get; set; }

        [StringLength(255)]
        public string LineNote { get; set; }

        public int? TotalCarton { get; set; }

        [StringLength(100)]
        public string DetailWarehouseID { get; set; }

        [StringLength(100)]
        public string CategoryID { get; set; }

        public int? OrderChangeAcknowledgmentHeader { get; set; }

        public int? MasterItemID { get; set; }

        public int? MasterKitID { get; set; }

        public int? TaxID { get; set; }

        public int? UOMCodeBase { get; set; }

        public int? UOMCode { get; set; }

        public int? DiscountID { get; set; }

        public int? BasisUnitPriceID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_BasisUnitPrice DIO_BasisUnitPrice { get; set; }

        public virtual DIO_Discount DIO_Discount { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem1 { get; set; }

        public virtual DIO_OrderChangeAcknowledgmentHeader DIO_OrderChangeAcknowledgmentHeader { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentDetailAllowanceCharge> DIO_OrderChangeAcknowledgmentDetailAllowanceCharge { get; set; }
    }
}
