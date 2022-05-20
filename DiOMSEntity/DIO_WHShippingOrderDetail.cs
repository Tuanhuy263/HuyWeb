namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHShippingOrderDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHShippingOrderDetail()
        {
            DIO_WHShippingAdviceDetail = new HashSet<DIO_WHShippingAdviceDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WHShippingOrderDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pack { get; set; }

        [Column(TypeName = "money")]
        public decimal? InnerPack { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? OriginalQuantity { get; set; }

        public int? LnNo { get; set; }

        [StringLength(100)]
        public string EDILnNo { get; set; }

        [StringLength(48)]
        public string EDILineNumber { get; set; }

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

        public int? MasterItemID { get; set; }

        public int? WeightUOMID { get; set; }

        public int? WHShippingOrderHeaderID { get; set; }

        public int? UOMCodeBase { get; set; }

        public int? UOMCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        public DateTime? ShippingDate { get; set; }

        [StringLength(100)]
        public string ShippingAccount { get; set; }

        [StringLength(100)]
        public string AdditionalRoutingDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? GroceryPackWeigh { get; set; }

        [Column(TypeName = "money")]
        public decimal? GroceryPackVolume { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(2)]
        public string QtyUOM { get; set; }

        [StringLength(255)]
        public string EDIItemDescription { get; set; }

        public int? ShippingSpeed { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippingQuantity { get; set; }

        public int? FromMasterLocationID { get; set; }

        public int? ToMasterLocationID { get; set; }

        [Column(TypeName = "money")]
        public decimal? SOShippedQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? SOOriginalQuantity { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceDetail> DIO_WHShippingAdviceDetail { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure2 { get; set; }

        public virtual DIO_WHShippingOrderHeader DIO_WHShippingOrderHeader { get; set; }
    }
}
