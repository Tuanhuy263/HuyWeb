namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_OrderChangeRequestDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_OrderChangeRequestDetail()
        {
            DIO_OrderChangeRequestDetailAllowanceCharge = new HashSet<DIO_OrderChangeRequestDetailAllowanceCharge>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(250)]
        public string LnNo { get; set; }

        [StringLength(250)]
        public string ProductDescription { get; set; }

        [StringLength(250)]
        public string ColorDescription { get; set; }

        [StringLength(250)]
        public string SizeDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderedQty { get; set; }

        [StringLength(10)]
        public string UPCQualifier { get; set; }

        [StringLength(30)]
        public string UPCCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? MarkForStoreQty { get; set; }

        [StringLength(10)]
        public string BuyerItemQualifier { get; set; }

        [StringLength(10)]
        public string BuyerItemNo { get; set; }

        [StringLength(10)]
        public string VendorItemQualifier { get; set; }

        [StringLength(10)]
        public string VendorItemNo { get; set; }

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
        public string OrderUOM { get; set; }

        [StringLength(250)]
        public string ItemChangeType { get; set; }

        [StringLength(250)]
        public string BasisUnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? POQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? RetailPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? PackSize { get; set; }

        [StringLength(255)]
        public string PackUOM { get; set; }

        public DateTime? RequestedShipDate { get; set; }

        public DateTime? RequestedDeliveryDate { get; set; }

        [StringLength(10)]
        public string ItemRouting { get; set; }

        [StringLength(10)]
        public string ItemMessage { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExtendedLineAmount { get; set; }

        [StringLength(10)]
        public string POChangeCode { get; set; }

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
        public decimal? TotalOrderAmount { get; set; }

        public int? NumberOfLine { get; set; }

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

        public int? Header { get; set; }

        public int? UOM { get; set; }

        public int? MasterItem { get; set; }

        public int? ManufactureAddress { get; set; }

        public int? MarkForStore { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_OrderChangeRequestHeader DIO_OrderChangeRequestHeader { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestDetailAllowanceCharge> DIO_OrderChangeRequestDetailAllowanceCharge { get; set; }
    }
}
