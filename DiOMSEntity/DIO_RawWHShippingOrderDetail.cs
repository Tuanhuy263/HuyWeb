namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawWHShippingOrderDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawWHShippingOrderDetailID { get; set; }

        [StringLength(255)]
        public string EDIItemDescription { get; set; }

        [StringLength(48)]
        public string ProductCode1 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(48)]
        public string ProductCode2 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(48)]
        public string ProductCode3 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(48)]
        public string ProductCode4 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(48)]
        public string ProductCode5 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(48)]
        public string ProductCode6 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(48)]
        public string ProductCode7 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(48)]
        public string ProductCode8 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(48)]
        public string ProductCode9 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(48)]
        public string ProductCode10 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier10 { get; set; }

        [StringLength(2)]
        public string BuyerCode { get; set; }

        [StringLength(255)]
        public string UserDefined113 { get; set; }

        [StringLength(250)]
        public string FutureUse114 { get; set; }

        [StringLength(250)]
        public string FutureUse184 { get; set; }

        [StringLength(250)]
        public string FutureUse189 { get; set; }

        [StringLength(48)]
        public string EDILineNumber { get; set; }

        public double? GSTAmount { get; set; }

        public double? HSTSalesTaxAmount { get; set; }

        [StringLength(30)]
        public string HSTSalesTaxID { get; set; }

        public int? MasterItemID { get; set; }

        [StringLength(100)]
        public string ProductDescription { get; set; }

        [StringLength(100)]
        public string ColorDescription { get; set; }

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

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyUnitOfMeasure { get; set; }

        [StringLength(2)]
        public string QtyUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyLeftToShipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? DropshipedQty { get; set; }

        [StringLength(100)]
        public string ShippingSpeed { get; set; }

        [StringLength(10)]
        public string UnitOfMeasure { get; set; }

        [Column(TypeName = "money")]
        public decimal? OriginalQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? GroceryPackWeigh { get; set; }

        [Column(TypeName = "money")]
        public decimal? GroceryPackVolume { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyShipped { get; set; }

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

        [StringLength(100)]
        public string BasisUnitPrice { get; set; }

        public double? ASQ { get; set; }

        public byte? Status { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxAfterDiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pack { get; set; }

        [Column(TypeName = "money")]
        public decimal? NoOfInnerPack { get; set; }

        [StringLength(100)]
        public string QBSODetailNo { get; set; }

        [StringLength(100)]
        public string QBMasterSODetailNo { get; set; }

        [StringLength(100)]
        public string QBSODetailDiscountNo { get; set; }

        [StringLength(100)]
        public string QBSODetailTaxNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemCommissionRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? NoOfInnerPacks { get; set; }

        public DateTime? ShippingDate { get; set; }

        [StringLength(100)]
        public string ShipToFacility { get; set; }

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

        [StringLength(20)]
        public string MarkForStoreNo { get; set; }

        [StringLength(250)]
        public string MarkForAddress1 { get; set; }

        [StringLength(250)]
        public string MarkForAddress2 { get; set; }

        [StringLength(50)]
        public string MarkForCity { get; set; }

        [StringLength(20)]
        public string MarkForState { get; set; }

        [StringLength(20)]
        public string MarkForZipCode { get; set; }

        [StringLength(250)]
        public string MarkForStoreName { get; set; }

        public int? RawWHShippingOrderHeaderID { get; set; }

        public int? MasterItem { get; set; }

        public int? UOMCodeBase { get; set; }

        [StringLength(10)]
        public string WeightUOM { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string IgnoredText { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIO_RawWHShippingOrderHeader DIO_RawWHShippingOrderHeader { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }
    }
}
