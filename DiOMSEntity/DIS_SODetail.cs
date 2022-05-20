namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_SODetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_SODetail()
        {
            DIO_ACKSODetail = new HashSet<DIO_ACKSODetail>();
            DIO_AllocatedPOSO = new HashSet<DIO_AllocatedPOSO>();
            DIO_AllocationItem = new HashSet<DIO_AllocationItem>();
            DIO_ERP_QBSODetailAllowanceCharge = new HashSet<DIO_ERP_QBSODetailAllowanceCharge>();
            DIO_POSODetail = new HashSet<DIO_POSODetail>();
            DIO_SaleRepSODetail = new HashSet<DIO_SaleRepSODetail>();
            DIO_SISODetail = new HashSet<DIO_SISODetail>();
            DIO_SODetailAllowanceCharge = new HashSet<DIO_SODetailAllowanceCharge>();
            DIO_SODetailPackage = new HashSet<DIO_SODetailPackage>();
            DIO_SubLineItem = new HashSet<DIO_SubLineItem>();
            DIO_TrackingOrderStatusDetail = new HashSet<DIO_TrackingOrderStatusDetail>();
            DIO_WHShippingAdviceDetail = new HashSet<DIO_WHShippingAdviceDetail>();
            DIO_WSTReceiptAdviceLineItemDetail = new HashSet<DIO_WSTReceiptAdviceLineItemDetail>();
            DIO_WSTShipmentAdviceLineItemDetail = new HashSet<DIO_WSTShipmentAdviceLineItemDetail>();
            DIS_LineItem = new HashSet<DIS_LineItem>();
            DIS_LineItemDetail = new HashSet<DIS_LineItemDetail>();
            DIS_SOAllocatedLocation = new HashSet<DIS_SOAllocatedLocation>();
        }

        [Key]
        public int SODetailNo { get; set; }

        public int? LnNo { get; set; }

        public int SONo { get; set; }

        public int? TaxID { get; set; }

        public decimal? TaxRate { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? TaxAfterDiscountAmount { get; set; }

        public int? UOMCodeBase { get; set; }

        public int? UOMCode { get; set; }

        public decimal? UOMRate { get; set; }

        [StringLength(255)]
        public string BuyerCode { get; set; }

        public float? GSTAmount { get; set; }

        public float? HSTSalesTaxAmount { get; set; }

        [StringLength(30)]
        public string HSTSalesTaxID { get; set; }

        public float? InnerPackNo { get; set; }

        [StringLength(30)]
        public string InvoiceGSTTaxID { get; set; }

        [StringLength(50)]
        public string ItemChangeType { get; set; }

        public float? ItemNoPerPack { get; set; }

        public int? MarkForStoreID { get; set; }

        [StringLength(80)]
        public string MechandiseType { get; set; }

        public decimal? MultPriceQty { get; set; }

        public decimal? QtyLeftToShipped { get; set; }

        [StringLength(2)]
        public string QtyUOM { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? QtyShipped { get; set; }

        public decimal? RetailPrice { get; set; }

        [StringLength(30)]
        public string TicketCode { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? Amount { get; set; }

        public float? ASQ { get; set; }

        public int MasterItemID { get; set; }

        public byte? Status { get; set; }

        public int? DiscountID { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? DiscountRate { get; set; }

        public decimal? Pack { get; set; }

        public decimal? NoOfInnerPack { get; set; }

        public int? BasisUnitPriceID { get; set; }

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

        public decimal? ItemCommissionRate { get; set; }

        [StringLength(255)]
        public string QBSODetailNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column("_SODetailFather")]
        public int? C_SODetailFather { get; set; }

        [StringLength(100)]
        public string QBSODetailDiscountNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? MasterKitQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? MasterKitQtyShipped { get; set; }

        public int? MasterKitID { get; set; }

        [Column(TypeName = "money")]
        public decimal? OriginalQuantity { get; set; }

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

        public decimal? GroceryPackVolume { get; set; }

        public decimal? GroceryPackWeigh { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TempInvoiceQty { get; set; }

        [StringLength(255)]
        public string UserDefined113 { get; set; }

        [Column(TypeName = "money")]
        public decimal? DropshipQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? DropshipedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyShippedByDropship { get; set; }

        [StringLength(255)]
        public string EDIItemDescription { get; set; }

        [StringLength(100)]
        public string ShippingAccount { get; set; }

        [StringLength(100)]
        public string AdditionalRoutingDescription { get; set; }

        public int? ShippingSpeed { get; set; }

        [StringLength(48)]
        public string EDILnNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAllowance { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCharge { get; set; }

        [StringLength(255)]
        public string EDILineNumber { get; set; }

        [StringLength(100)]
        public string QBSODetailTaxNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyShippedBase { get; set; }

        [StringLength(100)]
        public string QBMasterSODetailNo { get; set; }

        public int? ParentSODetailNo { get; set; }

        [StringLength(50)]
        public string ColorDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? Size { get; set; }

        [StringLength(250)]
        public string FutureUse114 { get; set; }

        [StringLength(250)]
        public string FutureUse184 { get; set; }

        [StringLength(250)]
        public string FutureUse189 { get; set; }

        public string GiftWrappingCode { get; set; }

        [StringLength(250)]
        public string LineInstruction { get; set; }

        public string GiftMessage { get; set; }

        public int? MasterLocationID { get; set; }

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

        [Column(TypeName = "money")]
        public decimal? AllocationQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? CanceledQty { get; set; }

        public int? AllocatedStatus { get; set; }

        [StringLength(255)]
        public string Shopify_LineItem { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity940 { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? PickQty { get; set; }

        public int? SubCustomerID { get; set; }

        [Column(TypeName = "money")]
        public decimal? FCLQuantity { get; set; }

        [StringLength(100)]
        public string PONumberFromShipmentReport { get; set; }

        public int? UOMSetID { get; set; }

        public int? BuyPlanStatusDetail { get; set; }

        public int? ACKDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? SKU_Allocated { get; set; }

        [Column(TypeName = "money")]
        public decimal? SKU_Allocated_Tmp { get; set; }

        public int? PriceChangeNoteID { get; set; }

        public int? CancelNote { get; set; }

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
        public string CustomField_String50_7 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_8 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_9 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_10 { get; set; }

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

        [Column(TypeName = "money")]
        public decimal? ACKQty { get; set; }

        [StringLength(250)]
        public string TrackingNumber { get; set; }

        [StringLength(250)]
        public string SCACCODE { get; set; }

        [StringLength(250)]
        public string ShipMethod { get; set; }

        [StringLength(250)]
        public string WarehouseID { get; set; }

        [StringLength(255)]
        public string OldERPItemCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ACKSODetail> DIO_ACKSODetail { get; set; }

        public virtual DIO_ACKSODetail DIO_ACKSODetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AllocatedPOSO> DIO_AllocatedPOSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AllocationItem> DIO_AllocationItem { get; set; }

        public virtual DIO_BasisUnitPrice DIO_BasisUnitPrice { get; set; }

        public virtual DIO_Discount DIO_Discount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ERP_QBSODetailAllowanceCharge> DIO_ERP_QBSODetailAllowanceCharge { get; set; }

        public virtual DIO_MarkForStore DIO_MarkForStore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POSODetail> DIO_POSODetail { get; set; }

        public virtual DIO_PriceChangeNote DIO_PriceChangeNote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SaleRepSODetail> DIO_SaleRepSODetail { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SISODetail> DIO_SISODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SODetailAllowanceCharge> DIO_SODetailAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SODetailPackage> DIO_SODetailPackage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SubLineItem> DIO_SubLineItem { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TrackingOrderStatusDetail> DIO_TrackingOrderStatusDetail { get; set; }

        public virtual DIO_UOMSet DIO_UOMSet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceDetail> DIO_WHShippingAdviceDetail { get; set; }

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

        public virtual DIS_MasterItem DIS_MasterItem1 { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOAllocatedLocation> DIS_SOAllocatedLocation { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }
    }
}
