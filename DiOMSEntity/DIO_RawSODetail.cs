namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawSODetail
    {
        [Key]
        public int RawSODetailId { get; set; }

        public int RawSOHeaderId { get; set; }

        [StringLength(250)]
        public string ProductCode1 { get; set; }

        [StringLength(250)]
        public string ProductCode2 { get; set; }

        [StringLength(250)]
        public string ProductCode3 { get; set; }

        [StringLength(250)]
        public string ProductCode4 { get; set; }

        [StringLength(48)]
        public string ProductCode5 { get; set; }

        [StringLength(250)]
        public string ProductCode6 { get; set; }

        [StringLength(250)]
        public string ProductCode7 { get; set; }

        [StringLength(250)]
        public string ProductCode8 { get; set; }

        [StringLength(250)]
        public string ProductCode9 { get; set; }

        [StringLength(250)]
        public string ProductCode10 { get; set; }

        public int? LnNo { get; set; }

        public decimal? Qty { get; set; }

        [StringLength(10)]
        public string UnitOfMeasure { get; set; }

        public decimal? UnitPrice { get; set; }

        [StringLength(2)]
        public string BasisUnitPrice { get; set; }

        public decimal? RetailPrice { get; set; }

        public decimal? MultPriceQty { get; set; }

        [StringLength(250)]
        public string ProductDescription { get; set; }

        [StringLength(250)]
        public string ColorDescription { get; set; }

        public decimal? Size { get; set; }

        [StringLength(250)]
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

        [StringLength(30)]
        public string BuyerCode { get; set; }

        public decimal? Pack { get; set; }

        [StringLength(30)]
        public string TicketCode { get; set; }

        [StringLength(250)]
        public string ShipToFacility { get; set; }

        [StringLength(250)]
        public string FutureUse114 { get; set; }

        public decimal? NoOfInnerPacks { get; set; }

        [StringLength(50)]
        public string ItemChangeType { get; set; }

        public decimal? QtyLeftToShipped { get; set; }

        public decimal? QtyUnitOfMeasure { get; set; }

        public decimal? ExtendedLineAmount { get; set; }

        [StringLength(20)]
        public string ProductCode1Qualifier { get; set; }

        [StringLength(20)]
        public string ProductCode2Qualifier { get; set; }

        [StringLength(2)]
        public string ProductCode3Qualifier { get; set; }

        [StringLength(20)]
        public string ProductCode4Qualifier { get; set; }

        [StringLength(2)]
        public string ProductCode5Qualifier { get; set; }

        [StringLength(20)]
        public string ProductCode6Qualifier { get; set; }

        [StringLength(20)]
        public string ProductCode7Qualifier { get; set; }

        [StringLength(20)]
        public string ProductCode8Qualifier { get; set; }

        [StringLength(20)]
        public string ProductCode9Qualifier { get; set; }

        [StringLength(20)]
        public string ProductCode10Qualifier { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator1 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode1 { get; set; }

        public decimal? LineAllowanceOrChargeAmount1 { get; set; }

        public decimal? LineAllowanceOrChargePercent1 { get; set; }

        [StringLength(20)]
        public string LineAllowanceMethodOfHandling1 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator2 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode2 { get; set; }

        public decimal? LineAllowanceOrChargeAmount2 { get; set; }

        public decimal? LineAllowanceOrChargePercent2 { get; set; }

        [StringLength(20)]
        public string LineAllowanceMethodOfHandling2 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator3 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode3 { get; set; }

        public decimal? LineAllowanceOrChargeAmount3 { get; set; }

        public decimal? LineAllowanceOrChargePercent3 { get; set; }

        [StringLength(20)]
        public string LineAllowanceMethodOfHandling3 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator4 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode4 { get; set; }

        public decimal? LineAllowanceOrChargeAmount4 { get; set; }

        public decimal? LineAllowanceOrChargePercent4 { get; set; }

        [StringLength(20)]
        public string LineAllowanceMethodOfHandling4 { get; set; }

        [StringLength(20)]
        public string FutureUse184 { get; set; }

        public decimal? LineItemGroceryAllowanceRate1 { get; set; }

        public decimal? LineItemGroceryAllowanceRate2 { get; set; }

        public decimal? LineItemGroceryAllowanceRate3 { get; set; }

        public decimal? LineItemGroceryAllowanceRate4 { get; set; }

        [StringLength(250)]
        public string FutureUse189 { get; set; }

        public decimal? LineItemQuantity1 { get; set; }

        public decimal? LineItemQuantity2 { get; set; }

        public decimal? LineItemQuantity3 { get; set; }

        public decimal? LineItemQuantity4 { get; set; }

        [StringLength(30)]
        public string InvoiceGTSTaxID { get; set; }

        public decimal? GSTAmount { get; set; }

        [StringLength(30)]
        public string HSTSalesTaxID { get; set; }

        public decimal? HSTSalesTaxAmount { get; set; }

        public int? MasterItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

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

        public decimal? OriginalQuantity { get; set; }

        public decimal? GroceryPackVolume { get; set; }

        public decimal? GroceryPackWeigh { get; set; }

        [StringLength(255)]
        public string UserDefined113 { get; set; }

        [StringLength(100)]
        public string ShippingAccount { get; set; }

        [StringLength(100)]
        public string AdditionalRoutingDescription { get; set; }

        [StringLength(100)]
        public string ShippingSpeed { get; set; }

        public DateTime? ShippingDate { get; set; }

        [StringLength(48)]
        public string EDILineNumber { get; set; }

        [StringLength(255)]
        public string LineAllowanceDescription1 { get; set; }

        [StringLength(255)]
        public string LineAllowanceDescription2 { get; set; }

        [StringLength(255)]
        public string LineAllowanceDescription3 { get; set; }

        [StringLength(255)]
        public string LineAllowanceDescription4 { get; set; }

        public string GiftWrappingCode { get; set; }

        [StringLength(250)]
        public string LineInstruction { get; set; }

        public string GiftMessage { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator5 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent5 { get; set; }

        [StringLength(20)]
        public string LineAllowanceMethodOfHandling5 { get; set; }

        [StringLength(255)]
        public string LineAllowanceDescription5 { get; set; }

        public bool? IsUserMapItem { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemGroceryAllowanceRate5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemQuantity5 { get; set; }

        [StringLength(250)]
        public string MarkForQualifier { get; set; }

        [StringLength(255)]
        public string LineAllowanceOrChargeDescription1 { get; set; }

        [StringLength(255)]
        public string LineAllowanceOrChargeDescription2 { get; set; }

        [StringLength(255)]
        public string LineAllowanceOrChargeDescription3 { get; set; }

        [StringLength(255)]
        public string LineAllowanceOrChargeDescription4 { get; set; }

        [StringLength(255)]
        public string LineAllowanceOrChargeDescription5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty5 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of1 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvailabletoShipQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemVolume { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemWidth { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemHeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemDepth { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceMultiplier { get; set; }

        [StringLength(255)]
        public string UserDefined193 { get; set; }

        [StringLength(255)]
        public string UserDefined195 { get; set; }

        [StringLength(255)]
        public string UserDefined203 { get; set; }

        [StringLength(255)]
        public string UserDefined204 { get; set; }

        [StringLength(255)]
        public string PackUOM { get; set; }

        [StringLength(255)]
        public string SAPBatchNo { get; set; }

        [StringLength(255)]
        public string POLineNo { get; set; }

        [StringLength(255)]
        public string DeptNo { get; set; }

        [StringLength(255)]
        public string DeptName { get; set; }

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

        [StringLength(255)]
        public string ItemDepartNo { get; set; }

        [StringLength(255)]
        public string ItemDepartName { get; set; }

        [StringLength(250)]
        public string MarkForCountry { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator6 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent6 { get; set; }

        [StringLength(100)]
        public string LineAllowanceMethodOfHandling6 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator7 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent7 { get; set; }

        [StringLength(100)]
        public string LineAllowanceMethodOfHandling7 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator8 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent8 { get; set; }

        [StringLength(100)]
        public string LineAllowanceMethodOfHandling8 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator9 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent9 { get; set; }

        [StringLength(100)]
        public string LineAllowanceMethodOfHandling9 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator10 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent10 { get; set; }

        [StringLength(100)]
        public string LineAllowanceMethodOfHandling10 { get; set; }

        [StringLength(255)]
        public string LineAllowanceOrChargeDescription6 { get; set; }

        [StringLength(255)]
        public string LineAllowanceOrChargeDescription7 { get; set; }

        [StringLength(255)]
        public string LineAllowanceOrChargeDescription8 { get; set; }

        [StringLength(255)]
        public string LineAllowanceOrChargeDescription9 { get; set; }

        [StringLength(255)]
        public string LineAllowanceOrChargeDescription10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty10 { get; set; }

        [StringLength(255)]
        public string Shopify_LineItem { get; set; }

        public int? NumberOfmailPerDay { get; set; }

        public DateTime? SendMailDate { get; set; }

        public int? PriceChangeNoteID { get; set; }

        [StringLength(50)]
        public string CustomField_String50_1 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_2 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_3 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_4 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_5 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_6 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_9 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_10 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_7 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_10 { get; set; }

        public bool? CustomField_Bool_1 { get; set; }

        public bool? CustomField_Bool_2 { get; set; }

        public bool? CustomField_Bool_3 { get; set; }

        public bool? CustomField_Bool_4 { get; set; }

        public bool? CustomField_Bool_5 { get; set; }

        public bool? CustomField_Bool_6 { get; set; }

        public bool? CustomField_Bool_7 { get; set; }

        public bool? CustomField_Bool_8 { get; set; }

        public bool? CustomField_Bool_9 { get; set; }

        public bool? CustomField_Bool_10 { get; set; }

        public DateTime? CustomField_DateTime_1 { get; set; }

        public DateTime? CustomField_DateTime_2 { get; set; }

        public DateTime? CustomField_DateTime_3 { get; set; }

        public DateTime? CustomField_DateTime_4 { get; set; }

        public DateTime? CustomField_DateTime_5 { get; set; }

        public DateTime? CustomField_DateTime_6 { get; set; }

        public DateTime? CustomField_DateTime_7 { get; set; }

        public DateTime? CustomField_DateTime_8 { get; set; }

        public DateTime? CustomField_DateTime_9 { get; set; }

        public DateTime? CustomField_DateTime_10 { get; set; }

        public int? CustomField_Int_1 { get; set; }

        public int? CustomField_Int_2 { get; set; }

        public int? CustomField_Int_3 { get; set; }

        public int? CustomField_Int_4 { get; set; }

        public int? CustomField_Int_5 { get; set; }

        public int? CustomField_Int_6 { get; set; }

        public int? CustomField_Int_7 { get; set; }

        public int? CustomField_Int_8 { get; set; }

        public int? CustomField_Int_9 { get; set; }

        public int? CustomField_Int_10 { get; set; }

        public long? CustomField_Long_1 { get; set; }

        public long? CustomField_Long_2 { get; set; }

        public long? CustomField_Long_3 { get; set; }

        public long? CustomField_Long_4 { get; set; }

        public long? CustomField_Long_5 { get; set; }

        public long? CustomField_Long_6 { get; set; }

        public long? CustomField_Long_7 { get; set; }

        public long? CustomField_Long_8 { get; set; }

        public long? CustomField_Long_9 { get; set; }

        public long? CustomField_Long_10 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_1 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_2 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_3 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_4 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_5 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_6 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_7 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_8 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_9 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_10 { get; set; }

        [StringLength(250)]
        public string TrackingNumber { get; set; }

        [StringLength(250)]
        public string SCACCODE { get; set; }

        [StringLength(250)]
        public string ShipMethod { get; set; }

        [StringLength(250)]
        public string WarehouseID { get; set; }

        public virtual DIO_PriceChangeNote DIO_PriceChangeNote { get; set; }

        public virtual DIO_RawSOHeader DIO_RawSOHeader { get; set; }
    }
}
