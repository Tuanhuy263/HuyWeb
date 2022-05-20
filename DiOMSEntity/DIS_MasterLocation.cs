namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_MasterLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_MasterLocation()
        {
            DIO_AdjustmentDetail = new HashSet<DIO_AdjustmentDetail>();
            DIO_AdjustmentHeader = new HashSet<DIO_AdjustmentHeader>();
            DIO_AssignLocation = new HashSet<DIO_AssignLocation>();
            DIO_AverageSalesOfLastYear = new HashSet<DIO_AverageSalesOfLastYear>();
            DIO_Batch = new HashSet<DIO_Batch>();
            DIO_BlanketPODetail = new HashSet<DIO_BlanketPODetail>();
            DIO_BlanketPOHeader = new HashSet<DIO_BlanketPOHeader>();
            DIO_BlanketSODetail = new HashSet<DIO_BlanketSODetail>();
            DIO_BlanketSOHeader = new HashSet<DIO_BlanketSOHeader>();
            DIO_InventoryAdviceDetail = new HashSet<DIO_InventoryAdviceDetail>();
            DIO_InventoryAdviceLocation = new HashSet<DIO_InventoryAdviceLocation>();
            DIO_InventoryCarton = new HashSet<DIO_InventoryCarton>();
            DIO_InventoryCarton1 = new HashSet<DIO_InventoryCarton>();
            DIO_InventoryCartonShippingAdvice = new HashSet<DIO_InventoryCartonShippingAdvice>();
            DIO_InventoryCartonShippingAdvice1 = new HashSet<DIO_InventoryCartonShippingAdvice>();
            DIO_InventoryLineItemShippingAdvice = new HashSet<DIO_InventoryLineItemShippingAdvice>();
            DIO_InventoryPallet = new HashSet<DIO_InventoryPallet>();
            DIO_InventoryPallet1 = new HashSet<DIO_InventoryPallet>();
            DIO_InventoryPalletShippingAdvice = new HashSet<DIO_InventoryPalletShippingAdvice>();
            DIO_InventoryPalletShippingAdvice1 = new HashSet<DIO_InventoryPalletShippingAdvice>();
            DIO_InventoryValuationAudit = new HashSet<DIO_InventoryValuationAudit>();
            DIO_ItemShippingAdvice = new HashSet<DIO_ItemShippingAdvice>();
            DIO_IVABatch = new HashSet<DIO_IVABatch>();
            DIO_LandedCostLineItem = new HashSet<DIO_LandedCostLineItem>();
            DIO_LocationManagement = new HashSet<DIO_LocationManagement>();
            DIO_LocationTransaction = new HashSet<DIO_LocationTransaction>();
            DIO_MovingAverageQty = new HashSet<DIO_MovingAverageQty>();
            DIO_nSerial = new HashSet<DIO_nSerial>();
            DIO_OpenPack = new HashSet<DIO_OpenPack>();
            DIO_OpenPackDetail = new HashSet<DIO_OpenPackDetail>();
            DIO_PackDetail = new HashSet<DIO_PackDetail>();
            DIO_PackItem = new HashSet<DIO_PackItem>();
            DIO_PackItemDetailLocation = new HashSet<DIO_PackItemDetailLocation>();
            DIO_PickDetailBarcode = new HashSet<DIO_PickDetailBarcode>();
            DIO_PickDetailCarton = new HashSet<DIO_PickDetailCarton>();
            DIO_PickDetailItem = new HashSet<DIO_PickDetailItem>();
            DIO_PickDetailItem1 = new HashSet<DIO_PickDetailItem>();
            DIO_PickDetailPallet = new HashSet<DIO_PickDetailPallet>();
            DIO_PickHeader = new HashSet<DIO_PickHeader>();
            DIO_PickingListDetail = new HashSet<DIO_PickingListDetail>();
            DIO_PickingListDetail1 = new HashSet<DIO_PickingListDetail>();
            DIO_ProjectSales = new HashSet<DIO_ProjectSales>();
            DIO_PTSCarton = new HashSet<DIO_PTSCarton>();
            DIO_PurchaseTransitTime = new HashSet<DIO_PurchaseTransitTime>();
            DIO_ReceivingCartonItem = new HashSet<DIO_ReceivingCartonItem>();
            DIO_ReceivingHeader = new HashSet<DIO_ReceivingHeader>();
            DIO_ReceivingItem = new HashSet<DIO_ReceivingItem>();
            DIO_RepackSerial = new HashSet<DIO_RepackSerial>();
            DIO_ReturnReceipt = new HashSet<DIO_ReturnReceipt>();
            DIO_ReturnReceiptDetail = new HashSet<DIO_ReturnReceiptDetail>();
            DIO_ReturnShipment = new HashSet<DIO_ReturnShipment>();
            DIO_ReturnShipmentDetail = new HashSet<DIO_ReturnShipmentDetail>();
            DIO_RoutingByZipCode = new HashSet<DIO_RoutingByZipCode>();
            DIO_Serial = new HashSet<DIO_Serial>();
            DIO_SplitSOCriteria = new HashSet<DIO_SplitSOCriteria>();
            DIO_TotalPastShipQty = new HashSet<DIO_TotalPastShipQty>();
            DIO_TransferCarton = new HashSet<DIO_TransferCarton>();
            DIO_TransferCarton1 = new HashSet<DIO_TransferCarton>();
            DIO_TransferDetail = new HashSet<DIO_TransferDetail>();
            DIO_TransferDetail1 = new HashSet<DIO_TransferDetail>();
            DIO_TransferDocumentDetail = new HashSet<DIO_TransferDocumentDetail>();
            DIO_TransferDocumentDetail1 = new HashSet<DIO_TransferDocumentDetail>();
            DIO_TransferDocumentLineDetail = new HashSet<DIO_TransferDocumentLineDetail>();
            DIO_TransferDocumentLineDetail1 = new HashSet<DIO_TransferDocumentLineDetail>();
            DIO_TransferHeader = new HashSet<DIO_TransferHeader>();
            DIO_TransferPallet = new HashSet<DIO_TransferPallet>();
            DIO_TransferPallet1 = new HashSet<DIO_TransferPallet>();
            DIO_WarehouseLevelDetail = new HashSet<DIO_WarehouseLevelDetail>();
            DIO_WH947Header = new HashSet<DIO_WH947Header>();
            DIO_WH947LineItem = new HashSet<DIO_WH947LineItem>();
            DIO_WHOrderDetail = new HashSet<DIO_WHOrderDetail>();
            DIO_WHOrderHeader = new HashSet<DIO_WHOrderHeader>();
            DIO_WHRecipientNoticeDetail = new HashSet<DIO_WHRecipientNoticeDetail>();
            DIO_WHRecipientNoticeHeader = new HashSet<DIO_WHRecipientNoticeHeader>();
            DIO_WHShippingOrderDetail = new HashSet<DIO_WHShippingOrderDetail>();
            DIO_WHShippingOrderDetail1 = new HashSet<DIO_WHShippingOrderDetail>();
            DIO_WHShippingOrderHeader = new HashSet<DIO_WHShippingOrderHeader>();
            DIO_WHShippingOrderHeader1 = new HashSet<DIO_WHShippingOrderHeader>();
            DIO_WHStockIn = new HashSet<DIO_WHStockIn>();
            DIO_WHStockIn1 = new HashSet<DIO_WHStockIn>();
            DIO_WHStockInDetail = new HashSet<DIO_WHStockInDetail>();
            DIO_WHStockOut = new HashSet<DIO_WHStockOut>();
            DIO_WHStockOut1 = new HashSet<DIO_WHStockOut>();
            DIO_WHStockOutDetail = new HashSet<DIO_WHStockOutDetail>();
            DIO_WorkOrder = new HashSet<DIO_WorkOrder>();
            DIO_WorkOrderDetails = new HashSet<DIO_WorkOrderDetails>();
            DIO_WSTReceiptAdviceCarton = new HashSet<DIO_WSTReceiptAdviceCarton>();
            DIO_WSTReceiptAdviceHeader = new HashSet<DIO_WSTReceiptAdviceHeader>();
            DIO_WSTReceiptAdviceLineItem = new HashSet<DIO_WSTReceiptAdviceLineItem>();
            DIO_WSTReceiptAdvicePallet = new HashSet<DIO_WSTReceiptAdvicePallet>();
            DIO_WSTShipmentAdviceHeader = new HashSet<DIO_WSTShipmentAdviceHeader>();
            DIOW_LocationItemPars = new HashSet<DIOW_LocationItemPars>();
            DIS_Carton = new HashSet<DIS_Carton>();
            DIS_CartonTransaction = new HashSet<DIS_CartonTransaction>();
            DIS_Hub = new HashSet<DIS_Hub>();
            DIS_HubItem = new HashSet<DIS_HubItem>();
            DIS_PODetail = new HashSet<DIS_PODetail>();
            DIS_POHeader = new HashSet<DIS_POHeader>();
            DIS_PurchaseInvoiceDetail = new HashSet<DIS_PurchaseInvoiceDetail>();
            DIS_SaleInvoiceDetail = new HashSet<DIS_SaleInvoiceDetail>();
            DIS_SaleInvoiceDetail1 = new HashSet<DIS_SaleInvoiceDetail>();
            DIS_SaleInvoiceHeader = new HashSet<DIS_SaleInvoiceHeader>();
            DIS_SODetail = new HashSet<DIS_SODetail>();
            DIS_SOHeader = new HashSet<DIS_SOHeader>();
            DIS_MasterLocation1 = new HashSet<DIS_MasterLocation>();
            DIS_PalletTransaction = new HashSet<DIS_PalletTransaction>();
            DIS_POHeader1 = new HashSet<DIS_POHeader>();
            DIS_SaleInvoiceDetail2 = new HashSet<DIS_SaleInvoiceDetail>();
            DIS_SOAllocatedLocation = new HashSet<DIS_SOAllocatedLocation>();
            DIS_SOAllocatedLocation1 = new HashSet<DIS_SOAllocatedLocation>();
            TmpAdjustmentHeaders = new HashSet<TmpAdjustmentHeader>();
            TmpTransferCartons = new HashSet<TmpTransferCarton>();
            TmpTransferDetails = new HashSet<TmpTransferDetail>();
            TmpTransferPallets = new HashSet<TmpTransferPallet>();
            TmpTransferHeaders = new HashSet<TmpTransferHeader>();
            DIS_VendorItem = new HashSet<DIS_VendorItem>();
        }

        [Key]
        public int MasterLocationID { get; set; }

        [StringLength(250)]
        public string MasterLocationCode { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? StatusCodeID { get; set; }

        public int? WarehouseTypeID { get; set; }

        [StringLength(13)]
        public string GLN { get; set; }

        public short? GLNType { get; set; }

        public int? ThirdPartyLogisticID { get; set; }

        public int? ShippingInfoID { get; set; }

        public int? ParentID { get; set; }

        [StringLength(250)]
        public string LevelCode { get; set; }

        public bool? DefaultLocation { get; set; }

        public int? HubID { get; set; }

        public int? SequenceNumber { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? ReplicationDate { get; set; }

        public bool? IsExported846 { get; set; }

        public DateTime? Exported846Time { get; set; }

        public bool? IsWarehouseCount { get; set; }

        public int? VendorID { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(250)]
        public string QBID { get; set; }

        [StringLength(255)]
        public string PickupContactName { get; set; }

        [StringLength(255)]
        public string PickupContactPhone { get; set; }

        [StringLength(4000)]
        public string PickupContactEmail { get; set; }

        [StringLength(100)]
        public string ShopifyLocationID { get; set; }

        public int? Priority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentDetail> DIO_AdjustmentDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentHeader> DIO_AdjustmentHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AssignLocation> DIO_AssignLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AverageSalesOfLastYear> DIO_AverageSalesOfLastYear { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Batch> DIO_Batch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketPODetail> DIO_BlanketPODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketPOHeader> DIO_BlanketPOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketSODetail> DIO_BlanketSODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketSOHeader> DIO_BlanketSOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryAdviceDetail> DIO_InventoryAdviceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryAdviceLocation> DIO_InventoryAdviceLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryCarton> DIO_InventoryCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryCarton> DIO_InventoryCarton1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryCartonShippingAdvice> DIO_InventoryCartonShippingAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryCartonShippingAdvice> DIO_InventoryCartonShippingAdvice1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdvice> DIO_InventoryLineItemShippingAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryPallet> DIO_InventoryPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryPallet> DIO_InventoryPallet1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryPalletShippingAdvice> DIO_InventoryPalletShippingAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryPalletShippingAdvice> DIO_InventoryPalletShippingAdvice1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryValuationAudit> DIO_InventoryValuationAudit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ItemShippingAdvice> DIO_ItemShippingAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_IVABatch> DIO_IVABatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LandedCostLineItem> DIO_LandedCostLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LocationManagement> DIO_LocationManagement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LocationTransaction> DIO_LocationTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MovingAverageQty> DIO_MovingAverageQty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_nSerial> DIO_nSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPack> DIO_OpenPack { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPackDetail> DIO_OpenPackDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetail> DIO_PackDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItem> DIO_PackItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemDetailLocation> DIO_PackItemDetailLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailBarcode> DIO_PickDetailBarcode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailCarton> DIO_PickDetailCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailItem> DIO_PickDetailItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailItem> DIO_PickDetailItem1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailPallet> DIO_PickDetailPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickHeader> DIO_PickHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickingListDetail> DIO_PickingListDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickingListDetail> DIO_PickingListDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProjectSales> DIO_ProjectSales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSCarton> DIO_PTSCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PurchaseTransitTime> DIO_PurchaseTransitTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingCartonItem> DIO_ReceivingCartonItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingHeader> DIO_ReceivingHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingItem> DIO_ReceivingItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RepackSerial> DIO_RepackSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnReceipt> DIO_ReturnReceipt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnReceiptDetail> DIO_ReturnReceiptDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnShipment> DIO_ReturnShipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnShipmentDetail> DIO_ReturnShipmentDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RoutingByZipCode> DIO_RoutingByZipCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Serial> DIO_Serial { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SplitSOCriteria> DIO_SplitSOCriteria { get; set; }

        public virtual DIO_StatusCode DIO_StatusCode { get; set; }

        public virtual DIO_ThirdPartyLogistic DIO_ThirdPartyLogistic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TotalPastShipQty> DIO_TotalPastShipQty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferCarton> DIO_TransferCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferCarton> DIO_TransferCarton1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferDetail> DIO_TransferDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferDetail> DIO_TransferDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferDocumentDetail> DIO_TransferDocumentDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferDocumentDetail> DIO_TransferDocumentDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferDocumentLineDetail> DIO_TransferDocumentLineDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferDocumentLineDetail> DIO_TransferDocumentLineDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferHeader> DIO_TransferHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferPallet> DIO_TransferPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferPallet> DIO_TransferPallet1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WarehouseLevelDetail> DIO_WarehouseLevelDetail { get; set; }

        public virtual DIO_WarehouseType DIO_WarehouseType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WH947Header> DIO_WH947Header { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WH947LineItem> DIO_WH947LineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderDetail> DIO_WHOrderDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderHeader> DIO_WHOrderHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHRecipientNoticeDetail> DIO_WHRecipientNoticeDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHRecipientNoticeHeader> DIO_WHRecipientNoticeHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderDetail> DIO_WHShippingOrderDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderDetail> DIO_WHShippingOrderDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderHeader> DIO_WHShippingOrderHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderHeader> DIO_WHShippingOrderHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockIn> DIO_WHStockIn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockIn> DIO_WHStockIn1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockInDetail> DIO_WHStockInDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockOut> DIO_WHStockOut { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockOut> DIO_WHStockOut1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockOutDetail> DIO_WHStockOutDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrder> DIO_WorkOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrderDetails> DIO_WorkOrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceCarton> DIO_WSTReceiptAdviceCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceHeader> DIO_WSTReceiptAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceLineItem> DIO_WSTReceiptAdviceLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePallet> DIO_WSTReceiptAdvicePallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceHeader> DIO_WSTShipmentAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIOW_LocationItemPars> DIOW_LocationItemPars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Carton> DIS_Carton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_CartonTransaction> DIS_CartonTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Hub> DIS_Hub { get; set; }

        public virtual DIS_Hub DIS_Hub1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_HubItem> DIS_HubItem { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PODetail> DIS_PODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_POHeader> DIS_POHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceDetail> DIS_PurchaseInvoiceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceDetail> DIS_SaleInvoiceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceDetail> DIS_SaleInvoiceDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceHeader> DIS_SaleInvoiceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SODetail> DIS_SODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_MasterLocation> DIS_MasterLocation1 { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PalletTransaction> DIS_PalletTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_POHeader> DIS_POHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceDetail> DIS_SaleInvoiceDetail2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOAllocatedLocation> DIS_SOAllocatedLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOAllocatedLocation> DIS_SOAllocatedLocation1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpAdjustmentHeader> TmpAdjustmentHeaders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpTransferCarton> TmpTransferCartons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpTransferDetail> TmpTransferDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpTransferPallet> TmpTransferPallets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpTransferHeader> TmpTransferHeaders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_VendorItem> DIS_VendorItem { get; set; }
    }
}
