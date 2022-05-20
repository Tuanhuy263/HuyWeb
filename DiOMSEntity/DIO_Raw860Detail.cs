namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Raw860Detail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int Raw860DetailID { get; set; }

        [StringLength(250)]
        public string ProductCode1 { get; set; }

        [StringLength(250)]
        public string ProductCode2 { get; set; }

        [StringLength(250)]
        public string ProductCode3 { get; set; }

        [StringLength(250)]
        public string ProductCode4 { get; set; }

        [StringLength(250)]
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

        [StringLength(250)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier10 { get; set; }

        [StringLength(250)]
        public string MarkForStoreNo { get; set; }

        [StringLength(250)]
        public string MarkForStoreAddress1 { get; set; }

        [StringLength(250)]
        public string MarkForStoreAddress2 { get; set; }

        [StringLength(250)]
        public string MarkForStoreCity { get; set; }

        [StringLength(250)]
        public string MarkForStoreState { get; set; }

        [StringLength(250)]
        public string MarkForStoreZipCode { get; set; }

        [StringLength(250)]
        public string MarkForStoreName { get; set; }

        [StringLength(250)]
        public string OrderUOM { get; set; }

        [StringLength(250)]
        public string LnNo { get; set; }

        [StringLength(250)]
        public string ProductDescription { get; set; }

        [StringLength(250)]
        public string ColorDescription { get; set; }

        [StringLength(250)]
        public string SizeDescription { get; set; }

        [StringLength(250)]
        public string UserDefine112 { get; set; }

        [StringLength(250)]
        public string UserDefine113 { get; set; }

        [StringLength(250)]
        public string ItemChangeType { get; set; }

        [StringLength(250)]
        public string BasisUnitPrice { get; set; }

        [StringLength(250)]
        public string ModifyUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? POQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvailableToShip { get; set; }

        [Column(TypeName = "money")]
        public decimal? GroceryPack { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pack { get; set; }

        [Column(TypeName = "money")]
        public decimal? NoOfInnerPack { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyLeftToShipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? RetailPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOrderAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExtendedLineAmount { get; set; }

        public int? NumberOfLine { get; set; }

        public int? Raw860ID { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? GroceryPackWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? GroceryPackVolume { get; set; }

        [StringLength(100)]
        public string EDISONumber { get; set; }

        public bool? IsValidData { get; set; }

        public bool? IsIgnored { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        public int? MasterItemID { get; set; }

        [Column(TypeName = "money")]
        public decimal? MarkForStoreQty { get; set; }

        [StringLength(10)]
        public string UPCQualifier { get; set; }

        [StringLength(30)]
        public string UPCCode { get; set; }

        [StringLength(10)]
        public string BuyerItemQualifier { get; set; }

        [StringLength(10)]
        public string BuyerItemNo { get; set; }

        [StringLength(10)]
        public string VendorItemQualifier { get; set; }

        [StringLength(10)]
        public string VendorItemNo { get; set; }

        [StringLength(255)]
        public string PackUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? PackSize { get; set; }

        public DateTime? RequestedShipDate { get; set; }

        public DateTime? RequestedDeliveryDate { get; set; }

        [StringLength(10)]
        public string ItemRouting { get; set; }

        [StringLength(10)]
        public string ItemMessage { get; set; }

        [StringLength(10)]
        public string POChangeCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderedQty { get; set; }

        [StringLength(250)]
        public string ManufactureCode { get; set; }

        [StringLength(250)]
        public string ManufactureName { get; set; }

        [StringLength(250)]
        public string ManufactureAddName { get; set; }

        [StringLength(250)]
        public string ManufactureAddress1 { get; set; }

        [StringLength(250)]
        public string ManufactureAddress2 { get; set; }

        [StringLength(50)]
        public string ManufactureCity { get; set; }

        [StringLength(20)]
        public string ManufactureState { get; set; }

        [StringLength(20)]
        public string ManufactureZipCode { get; set; }

        [StringLength(50)]
        public string ManufactureCountry { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator1 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent1 { get; set; }

        [StringLength(100)]
        public string LineAllowanceMethodOfHandling1 { get; set; }

        [StringLength(100)]
        public string LineAllowanceOrChargeIndicator2 { get; set; }

        [StringLength(100)]
        public string LineAllowanceOrChargeCode2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent2 { get; set; }

        [StringLength(100)]
        public string LineAllowanceMethodOfHandling2 { get; set; }

        [StringLength(100)]
        public string LineAllowanceOrChargeIndicator3 { get; set; }

        [StringLength(100)]
        public string LineAllowanceOrChargeCode3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent3 { get; set; }

        [StringLength(100)]
        public string LineAllowanceMethodOfHandling3 { get; set; }

        [StringLength(100)]
        public string LineAllowanceOrChargeDescription1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty1 { get; set; }

        [StringLength(100)]
        public string LineAllowanceOrChargeUnit1 { get; set; }

        [StringLength(100)]
        public string LineAllowanceOrChargeDescription2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty2 { get; set; }

        [StringLength(100)]
        public string LineAllowanceOrChargeUnit2 { get; set; }

        [StringLength(100)]
        public string LineAllowanceOrChargeDescription3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeRate3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeQty3 { get; set; }

        [StringLength(100)]
        public string LineAllowanceOrChargeUnit3 { get; set; }

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
        public string SubLineProductCode4of1 { get; set; }

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
        public string SubLineProductCode4of2 { get; set; }

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

        public virtual DIO_Raw860 DIO_Raw860 { get; set; }
    }
}
