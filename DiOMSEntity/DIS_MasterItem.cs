namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_MasterItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_MasterItem()
        {
            DIO_ACKSODetail = new HashSet<DIO_ACKSODetail>();
            DIO_ACKSODetail1 = new HashSet<DIO_ACKSODetail>();
            DIO_AdjustmentDetail = new HashSet<DIO_AdjustmentDetail>();
            DIO_AllocatedPOSO = new HashSet<DIO_AllocatedPOSO>();
            DIO_AllocatedPOSO1 = new HashSet<DIO_AllocatedPOSO>();
            DIO_AssignItem = new HashSet<DIO_AssignItem>();
            DIO_AutoReport = new HashSet<DIO_AutoReport>();
            DIO_AverageSalesOfLastYear = new HashSet<DIO_AverageSalesOfLastYear>();
            DIO_Batch = new HashSet<DIO_Batch>();
            DIO_BillOfMaterialDetail = new HashSet<DIO_BillOfMaterialDetail>();
            DIO_BlanketPODetail = new HashSet<DIO_BlanketPODetail>();
            DIO_BlanketSODetail = new HashSet<DIO_BlanketSODetail>();
            DIO_CategoryItems = new HashSet<DIO_CategoryItems>();
            DIO_CustomerCategoryPrice = new HashSet<DIO_CustomerCategoryPrice>();
            DIO_DefaultPackSize = new HashSet<DIO_DefaultPackSize>();
            DIO_ERP_Item = new HashSet<DIO_ERP_Item>();
            DIO_ERP_Term = new HashSet<DIO_ERP_Term>();
            DIO_GenerateAlternateItem = new HashSet<DIO_GenerateAlternateItem>();
            DIO_InventoryAdviceDetail = new HashSet<DIO_InventoryAdviceDetail>();
            DIO_InventoryLineItem = new HashSet<DIO_InventoryLineItem>();
            DIO_InventoryLineItemShippingAdvice = new HashSet<DIO_InventoryLineItemShippingAdvice>();
            DIO_InventoryValuationAudit = new HashSet<DIO_InventoryValuationAudit>();
            DIO_ItemDateRangePrice = new HashSet<DIO_ItemDateRangePrice>();
            DIO_ItemQuantityPrice = new HashSet<DIO_ItemQuantityPrice>();
            DIO_ItemShippingAdvice = new HashSet<DIO_ItemShippingAdvice>();
            DIO_IVABatch = new HashSet<DIO_IVABatch>();
            DIO_KitDetail = new HashSet<DIO_KitDetail>();
            DIO_KitDetail1 = new HashSet<DIO_KitDetail>();
            DIO_LandedCostLineItem = new HashSet<DIO_LandedCostLineItem>();
            DIO_LocationManagement = new HashSet<DIO_LocationManagement>();
            DIO_LocationManagementDetail = new HashSet<DIO_LocationManagementDetail>();
            DIO_LocationTransaction = new HashSet<DIO_LocationTransaction>();
            DIO_MasterEvent = new HashSet<DIO_MasterEvent>();
            DIO_MasterEventLineItem = new HashSet<DIO_MasterEventLineItem>();
            DIO_MasterItemFCL = new HashSet<DIO_MasterItemFCL>();
            DIO_MovingAverageQty = new HashSet<DIO_MovingAverageQty>();
            DIO_nSerial = new HashSet<DIO_nSerial>();
            DIO_OpenPack = new HashSet<DIO_OpenPack>();
            DIO_OrderChangeAcknowledgmentDetail = new HashSet<DIO_OrderChangeAcknowledgmentDetail>();
            DIO_OrderChangeAcknowledgmentDetail1 = new HashSet<DIO_OrderChangeAcknowledgmentDetail>();
            DIO_OrderChangeRequestDetail = new HashSet<DIO_OrderChangeRequestDetail>();
            DIO_OrderStatusReport870Detail = new HashSet<DIO_OrderStatusReport870Detail>();
            DIO_PackDetailItem = new HashSet<DIO_PackDetailItem>();
            DIO_PickDetailItem = new HashSet<DIO_PickDetailItem>();
            DIO_PickingListDetail = new HashSet<DIO_PickingListDetail>();
            DIO_ProductCodes = new HashSet<DIO_ProductCodes>();
            DIO_ProjectSales = new HashSet<DIO_ProjectSales>();
            DIO_PTSLineItem = new HashSet<DIO_PTSLineItem>();
            DIO_RawWHShippingOrderDetail = new HashSet<DIO_RawWHShippingOrderDetail>();
            DIO_ReceivingCartonItem = new HashSet<DIO_ReceivingCartonItem>();
            DIO_ReceivingItem = new HashSet<DIO_ReceivingItem>();
            DIO_RepackSerialItem = new HashSet<DIO_RepackSerialItem>();
            DIO_ReserveSerial = new HashSet<DIO_ReserveSerial>();
            DIO_ReturnReceiptDetail = new HashSet<DIO_ReturnReceiptDetail>();
            DIO_ReturnShipmentDetail = new HashSet<DIO_ReturnShipmentDetail>();
            DIO_Serial = new HashSet<DIO_Serial>();
            DIO_SerialConfiguration = new HashSet<DIO_SerialConfiguration>();
            DIO_SuggestionPrice = new HashSet<DIO_SuggestionPrice>();
            DIO_TotalPastShipQty = new HashSet<DIO_TotalPastShipQty>();
            DIO_TransferDetail = new HashSet<DIO_TransferDetail>();
            DIO_TransferDocumentDetail = new HashSet<DIO_TransferDocumentDetail>();
            DIO_VendorItemMasterItem = new HashSet<DIO_VendorItemMasterItem>();
            DIO_VendorItemMasterItem1 = new HashSet<DIO_VendorItemMasterItem>();
            DIO_WH947LineItem = new HashSet<DIO_WH947LineItem>();
            DIO_WHOrderDetail = new HashSet<DIO_WHOrderDetail>();
            DIO_WHRecipientNoticeDetail = new HashSet<DIO_WHRecipientNoticeDetail>();
            DIO_WHShippingAdviceDetail = new HashSet<DIO_WHShippingAdviceDetail>();
            DIO_WHShippingOrderDetail = new HashSet<DIO_WHShippingOrderDetail>();
            DIO_WHStockInDetail = new HashSet<DIO_WHStockInDetail>();
            DIO_WHStockInDetail1 = new HashSet<DIO_WHStockInDetail>();
            DIO_WHStockOutDetail = new HashSet<DIO_WHStockOutDetail>();
            DIO_WorkOrder = new HashSet<DIO_WorkOrder>();
            DIO_WorkOrderDetails = new HashSet<DIO_WorkOrderDetails>();
            DIO_WSTReceiptAdviceLineItem = new HashSet<DIO_WSTReceiptAdviceLineItem>();
            DIO_WSTShipmentAdviceLineItem = new HashSet<DIO_WSTShipmentAdviceLineItem>();
            DIOW_LocationItemPars = new HashSet<DIOW_LocationItemPars>();
            DIS_ASN = new HashSet<DIS_ASN>();
            DIS_HubItem = new HashSet<DIS_HubItem>();
            DIS_LineItem = new HashSet<DIS_LineItem>();
            DIS_MasterItem1 = new HashSet<DIS_MasterItem>();
            DIS_SaleInvoiceDetail = new HashSet<DIS_SaleInvoiceDetail>();
            DIS_SODetail = new HashSet<DIS_SODetail>();
            DIS_SOHeader = new HashSet<DIS_SOHeader>();
            DIS_VendorItem = new HashSet<DIS_VendorItem>();
            DIS_PODetail = new HashSet<DIS_PODetail>();
            DIS_PurchaseInvoiceDetail = new HashSet<DIS_PurchaseInvoiceDetail>();
            DIS_SaleInvoiceDetail1 = new HashSet<DIS_SaleInvoiceDetail>();
            DIS_SODetail1 = new HashSet<DIS_SODetail>();
            TmpAdjustmentDetails = new HashSet<TmpAdjustmentDetail>();
            TmpTransferDetails = new HashSet<TmpTransferDetail>();
        }

        [Key]
        public int MasterItemID { get; set; }

        public string Description { get; set; }

        public int? ProductPostingGroup { get; set; }

        public int? ColorID { get; set; }

        public int? SizeID { get; set; }

        public int? FabricID { get; set; }

        public int? UnitOfMeasureID { get; set; }

        public int? GroupItemID { get; set; }

        [StringLength(255)]
        public string GTIN { get; set; }

        [StringLength(255)]
        public string ERPItemCode { get; set; }

        [StringLength(255)]
        public string UPC { get; set; }

        [StringLength(255)]
        public string EAN { get; set; }

        public int? ItemType { get; set; }

        public int? OwnerType { get; set; }

        public int? GlobalStyle { get; set; }

        public decimal? Density { get; set; }

        public decimal? Depth { get; set; }

        public decimal? Diameter { get; set; }

        public decimal? Gauge { get; set; }

        public decimal? Length { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Width { get; set; }

        public decimal? Height { get; set; }

        public decimal? Volume { get; set; }

        public decimal? UnitPrice { get; set; }

        [StringLength(3)]
        public string BasicUnitPrice { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? LCost { get; set; }

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

        public byte? ManagementType { get; set; }

        public int? ValuationMethod { get; set; }

        public int? ObjectType { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        public decimal? PalletTie { get; set; }

        public decimal? PalletTier { get; set; }

        [StringLength(50)]
        public string GS1ItemID { get; set; }

        public decimal? SizeValue { get; set; }

        public int? SizeUOM { get; set; }

        public decimal? LengthBaseRate { get; set; }

        public decimal? WidthBaseRate { get; set; }

        public decimal? HeightBaseRate { get; set; }

        public decimal? WeightBaseRate { get; set; }

        public decimal? VolumeBaseRate { get; set; }

        public int? LengthBaseCode { get; set; }

        public int? LengthCode { get; set; }

        public int? WidthCode { get; set; }

        public int? HeightCode { get; set; }

        public int? VolumeCode { get; set; }

        public int? WeightBaseCode { get; set; }

        public int? WeightCode { get; set; }

        public int? CustomsID { get; set; }

        public bool? NonInventory { get; set; }

        public bool? NonReturnReceipt { get; set; }

        public bool? NonReturnShipment { get; set; }

        public byte? ItemStatus { get; set; }

        [StringLength(500)]
        public string ImagePath { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public decimal? MaxQty { get; set; }

        public decimal? MinQty { get; set; }

        public int? MinOrderMultiple { get; set; }

        public int? LeadTime { get; set; }

        public int? LeadTimeUnit { get; set; }

        public DateTime? ItemDiscontinueDate { get; set; }

        public int? ItemDiscontinueDateType { get; set; }

        public int? PackingSpecification { get; set; }

        public int? UPCType { get; set; }

        public int? HazardClass { get; set; }

        public int? Harmonize1 { get; set; }

        public int? Harmonize2 { get; set; }

        public int? NMFC { get; set; }

        [StringLength(255)]
        public string TradeBrandName { get; set; }

        public decimal? QuotaCategory { get; set; }

        public DateTime? ItemPublicationDate { get; set; }

        public decimal? ItemCommissionRate { get; set; }

        public decimal? ItemQtyPerMasterCarton { get; set; }

        public decimal? ItemQtyPerInnerCarton { get; set; }

        public decimal? ItemQtyPerPallet { get; set; }

        [StringLength(255)]
        public string ManufactureNumber { get; set; }

        [StringLength(255)]
        public string QBIncomeAccount { get; set; }

        [StringLength(255)]
        public string QBAssetAccount { get; set; }

        public int? BrandID { get; set; }

        public DateTime? ReplicationDate { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        public DateTime? QBModified { get; set; }

        public int? MadeIn { get; set; }

        [StringLength(255)]
        public string QBCOGSAccount { get; set; }

        [StringLength(255)]
        public string Department { get; set; }

        [Column(TypeName = "money")]
        public decimal? MSRP { get; set; }

        public DateTime? LastSyncDate { get; set; }

        public int? PricePolicy { get; set; }

        public int? QBClass { get; set; }

        public bool? NeedSyncToQB { get; set; }

        public bool? UseVolumeOnly { get; set; }

        [Column(TypeName = "money")]
        public decimal? CartonWeight { get; set; }

        public int? CartonWeightCode { get; set; }

        [StringLength(100)]
        public string OldQBID { get; set; }

        public bool? IsDuplicateQB { get; set; }

        [Column(TypeName = "money")]
        public decimal? UPSWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? UPSHeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? UPSLength { get; set; }

        [Column(TypeName = "money")]
        public decimal? UPSWidth { get; set; }

        public int? UPSWeightCode { get; set; }

        public int? UPSHeightCode { get; set; }

        public int? UPSWidthCode { get; set; }

        public int? UPSLengthCode { get; set; }

        public int? UPSPackageType { get; set; }

        public int? TransportationMethod { get; set; }

        public bool? BOM { get; set; }

        public int? Capacity { get; set; }

        public string Note { get; set; }

        [StringLength(255)]
        public string SmartTurnID { get; set; }

        [StringLength(255)]
        public string QBExpenseAccount { get; set; }

        [StringLength(255)]
        public string QBSaleTaxCodeID { get; set; }

        [StringLength(255)]
        public string QBPurchaseTaxCodeID { get; set; }

        [StringLength(1000)]
        public string ImagePaths { get; set; }

        [Column(TypeName = "money")]
        public decimal? MovingAverageGrowthRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? ForecastMinInventoryQty { get; set; }

        public int? ForecastLeadTimeShip { get; set; }

        public int? ForecastLeadTimeReceive { get; set; }

        [StringLength(100)]
        public string HighActivity { get; set; }

        public bool? IsHighVolume { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinPOQty { get; set; }

        [StringLength(255)]
        public string WHERPItemCode { get; set; }

        public int? OwnerID { get; set; }

        public DateTime? StartSalesDate { get; set; }

        public DateTime? EndSalesDate { get; set; }

        public bool? UseForSalesBudgetReport { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomsValue { get; set; }

        [StringLength(48)]
        public string MainPQ { get; set; }

        [StringLength(255)]
        public string Manufacture { get; set; }

        [StringLength(50)]
        public string Dosage { get; set; }

        [StringLength(255)]
        public string Strength { get; set; }

        [StringLength(50)]
        public string Container_Size { get; set; }

        [StringLength(50)]
        public string NDC { get; set; }

        [StringLength(200)]
        public string Indicator_In_GTIN_14 { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public int? CatalogID { get; set; }

        [StringLength(20)]
        public string DIV { get; set; }

        [StringLength(20)]
        public string SEA { get; set; }

        [StringLength(20)]
        public string GRP { get; set; }

        [StringLength(100)]
        public string ShopifyInventoryItemID { get; set; }

        [StringLength(50)]
        public string ColorDesc { get; set; }

        public int? Sequence { get; set; }

        public int? SequenceLength { get; set; }

        public int? ParentItemID { get; set; }

        [StringLength(100)]
        public string SKUNo { get; set; }

        [StringLength(100)]
        public string BLRNo { get; set; }

        [StringLength(300)]
        public string SortBy { get; set; }

        [StringLength(300)]
        public string SubProductDescription { get; set; }

        public int? Priority { get; set; }

        public bool? IsExported { get; set; }

        public DateTime? ExportedDate { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        [StringLength(250)]
        public string ShippingMethod { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty_Unit { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxReplPerBox { get; set; }

        [StringLength(100)]
        public string NonZonedShipDate { get; set; }

        [StringLength(100)]
        public string BoxDimensions { get; set; }

        [StringLength(1000)]
        public string Variety_Color { get; set; }

        [StringLength(1000)]
        public string ReconfiguredTo { get; set; }

        [StringLength(1000)]
        public string OldSKUNo { get; set; }

        [StringLength(1000)]
        public string ZoneShipping { get; set; }

        public int? SpecialBoxCannotCombine { get; set; }

        public DateTime? WHNextAvailableDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalSeasonAvailable { get; set; }

        [Column(TypeName = "money")]
        public decimal? Adjustment { get; set; }

        [Column(TypeName = "money")]
        public decimal? CalculatedInStock { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalShipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCancelled { get; set; }

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
        public decimal? ED_Length { get; set; }

        [Column(TypeName = "money")]
        public decimal? ED_Width { get; set; }

        [Column(TypeName = "money")]
        public decimal? ED_Height { get; set; }

        public bool? ED_UseVolumeOnly { get; set; }

        [Column(TypeName = "money")]
        public decimal? ED_Volume { get; set; }

        [Column(TypeName = "money")]
        public decimal? ED_Weight { get; set; }

        public int? ED_UOMLengthCode { get; set; }

        public int? ED_UOMWidthCode { get; set; }

        public int? ED_UOMHeightCode { get; set; }

        public int? ED_UOMVolumeCode { get; set; }

        public int? ED_UOMWeightCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? CQ_20FLC { get; set; }

        [Column(TypeName = "money")]
        public decimal? CQ_40FLC { get; set; }

        [Column(TypeName = "money")]
        public decimal? CQ_40HQ { get; set; }

        [Column(TypeName = "money")]
        public decimal? CQ_45FLC { get; set; }

        public int? CQ_20FLCCode { get; set; }

        public int? CQ_40FLCCode { get; set; }

        public int? CQ_40HQCode { get; set; }

        public int? CQ_45FLCCode { get; set; }

        [StringLength(255)]
        public string BarcodeNumber { get; set; }

        public bool? ItemIsExported { get; set; }

        [StringLength(255)]
        public string AlternateItems { get; set; }

        [StringLength(50)]
        public string TypeOfService { get; set; }

        public byte? Schedule { get; set; }

        public bool? DoNotUpdatePCToHubItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ACKSODetail> DIO_ACKSODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ACKSODetail> DIO_ACKSODetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentDetail> DIO_AdjustmentDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AllocatedPOSO> DIO_AllocatedPOSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AllocatedPOSO> DIO_AllocatedPOSO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AssignItem> DIO_AssignItem { get; set; }

        public virtual DIO_AttributeValue DIO_AttributeValue { get; set; }

        public virtual DIO_AttributeValue DIO_AttributeValue1 { get; set; }

        public virtual DIO_AttributeValue DIO_AttributeValue2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AutoReport> DIO_AutoReport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AverageSalesOfLastYear> DIO_AverageSalesOfLastYear { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Batch> DIO_Batch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BillOfMaterialDetail> DIO_BillOfMaterialDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketPODetail> DIO_BlanketPODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketSODetail> DIO_BlanketSODetail { get; set; }

        public virtual DIO_Brand DIO_Brand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CategoryItems> DIO_CategoryItems { get; set; }

        public virtual DIO_Country DIO_Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerCategoryPrice> DIO_CustomerCategoryPrice { get; set; }

        public virtual DIO_Customs DIO_Customs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_DefaultPackSize> DIO_DefaultPackSize { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ERP_Item> DIO_ERP_Item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ERP_Term> DIO_ERP_Term { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_GenerateAlternateItem> DIO_GenerateAlternateItem { get; set; }

        public virtual DIO_GroupItem DIO_GroupItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryAdviceDetail> DIO_InventoryAdviceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItem> DIO_InventoryLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdvice> DIO_InventoryLineItemShippingAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryValuationAudit> DIO_InventoryValuationAudit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ItemDateRangePrice> DIO_ItemDateRangePrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ItemQuantityPrice> DIO_ItemQuantityPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ItemShippingAdvice> DIO_ItemShippingAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_IVABatch> DIO_IVABatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_KitDetail> DIO_KitDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_KitDetail> DIO_KitDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LandedCostLineItem> DIO_LandedCostLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LocationManagement> DIO_LocationManagement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LocationManagementDetail> DIO_LocationManagementDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LocationTransaction> DIO_LocationTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterEvent> DIO_MasterEvent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterEventLineItem> DIO_MasterEventLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterItemFCL> DIO_MasterItemFCL { get; set; }

        public virtual DIO_MasterKit DIO_MasterKit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MovingAverageQty> DIO_MovingAverageQty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_nSerial> DIO_nSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPack> DIO_OpenPack { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentDetail> DIO_OrderChangeAcknowledgmentDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentDetail> DIO_OrderChangeAcknowledgmentDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestDetail> DIO_OrderChangeRequestDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderStatusReport870Detail> DIO_OrderStatusReport870Detail { get; set; }

        public virtual DIO_Owner DIO_Owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetailItem> DIO_PackDetailItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailItem> DIO_PickDetailItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickingListDetail> DIO_PickingListDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductCodes> DIO_ProductCodes { get; set; }

        public virtual DIO_ProductPostingGroup DIO_ProductPostingGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProjectSales> DIO_ProjectSales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSLineItem> DIO_PTSLineItem { get; set; }

        public virtual DIO_QBClass DIO_QBClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawWHShippingOrderDetail> DIO_RawWHShippingOrderDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingCartonItem> DIO_ReceivingCartonItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingItem> DIO_ReceivingItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RepackSerialItem> DIO_RepackSerialItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReserveSerial> DIO_ReserveSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnReceiptDetail> DIO_ReturnReceiptDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnShipmentDetail> DIO_ReturnShipmentDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Serial> DIO_Serial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SerialConfiguration> DIO_SerialConfiguration { get; set; }

        public virtual DIO_Style DIO_Style { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SuggestionPrice> DIO_SuggestionPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TotalPastShipQty> DIO_TotalPastShipQty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferDetail> DIO_TransferDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferDocumentDetail> DIO_TransferDocumentDetail { get; set; }

        public virtual DIO_TransportationMethod DIO_TransportationMethod { get; set; }

        public virtual DIO_UPSPackageType DIO_UPSPackageType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorItemMasterItem> DIO_VendorItemMasterItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorItemMasterItem> DIO_VendorItemMasterItem1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WH947LineItem> DIO_WH947LineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderDetail> DIO_WHOrderDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHRecipientNoticeDetail> DIO_WHRecipientNoticeDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceDetail> DIO_WHShippingAdviceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderDetail> DIO_WHShippingOrderDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockInDetail> DIO_WHStockInDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockInDetail> DIO_WHStockInDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockOutDetail> DIO_WHStockOutDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrder> DIO_WorkOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrderDetails> DIO_WorkOrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceLineItem> DIO_WSTReceiptAdviceLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceLineItem> DIO_WSTShipmentAdviceLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIOW_LocationItemPars> DIOW_LocationItemPars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_HubItem> DIS_HubItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_LineItem> DIS_LineItem { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure3 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure4 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure5 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure6 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure7 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure8 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure9 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_MasterItem> DIS_MasterItem1 { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure10 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure11 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure12 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure13 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceDetail> DIS_SaleInvoiceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SODetail> DIS_SODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_VendorItem> DIS_VendorItem { get; set; }

        public virtual Harmonize Harmonize { get; set; }

        public virtual Harmonize Harmonize3 { get; set; }

        public virtual HazardClass HazardClass1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure14 { get; set; }

        public virtual ItemDiscontinueDateType ItemDiscontinueDateType1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure15 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure16 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure17 { get; set; }

        public virtual NMFC NMFC1 { get; set; }

        public virtual PackingSpecification PackingSpecification1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure18 { get; set; }

        public virtual UPCType UPCType1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure19 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure20 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure21 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure22 { get; set; }

        public virtual XPObjectType XPObjectType { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure23 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PODetail> DIS_PODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceDetail> DIS_PurchaseInvoiceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceDetail> DIS_SaleInvoiceDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SODetail> DIS_SODetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpAdjustmentDetail> TmpAdjustmentDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpTransferDetail> TmpTransferDetails { get; set; }
    }
}
