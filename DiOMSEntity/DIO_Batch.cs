namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Batch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Batch()
        {
            DIO_AdjustmentBatch = new HashSet<DIO_AdjustmentBatch>();
            DIO_Batch_ReceivedDate = new HashSet<DIO_Batch_ReceivedDate>();
            DIO_BatchContainer = new HashSet<DIO_BatchContainer>();
            DIO_InventoryAdviceDetail = new HashSet<DIO_InventoryAdviceDetail>();
            DIO_InventoryLineItemShippingAdviceBatch = new HashSet<DIO_InventoryLineItemShippingAdviceBatch>();
            DIO_IVABatch = new HashSet<DIO_IVABatch>();
            DIO_LineItemDetailBatch = new HashSet<DIO_LineItemDetailBatch>();
            DIO_LocationManagementDetailBatch = new HashSet<DIO_LocationManagementDetailBatch>();
            DIO_nInventoryLineItemBatch = new HashSet<DIO_nInventoryLineItemBatch>();
            DIO_PackDetailItemBatch = new HashSet<DIO_PackDetailItemBatch>();
            DIO_PickDetailItemBatch = new HashSet<DIO_PickDetailItemBatch>();
            DIO_PickingListDetailBatch = new HashSet<DIO_PickingListDetailBatch>();
            DIO_ReceivingBatch = new HashSet<DIO_ReceivingBatch>();
            DIO_ReceivingCartonItemBatch = new HashSet<DIO_ReceivingCartonItemBatch>();
            DIO_WHOrderDetailBatch = new HashSet<DIO_WHOrderDetailBatch>();
            DIO_WHShippingAdviceDetailBatch = new HashSet<DIO_WHShippingAdviceDetailBatch>();
            DIO_WorkOrderInBatch = new HashSet<DIO_WorkOrderInBatch>();
            DIO_WSTReceiptAdviceLineItemBatch = new HashSet<DIO_WSTReceiptAdviceLineItemBatch>();
            DIO_WSTShipmentAdviceLineItemBatch = new HashSet<DIO_WSTShipmentAdviceLineItemBatch>();
            DIO_LineItemBatch = new HashSet<DIO_LineItemBatch>();
            DIO_OpenPackBatch = new HashSet<DIO_OpenPackBatch>();
            DIO_OpenPackDetailBatch = new HashSet<DIO_OpenPackDetailBatch>();
            DIO_PackItemBatch = new HashSet<DIO_PackItemBatch>();
            DIO_PackItemDetailLocationBatch = new HashSet<DIO_PackItemDetailLocationBatch>();
            DIO_PTSLineItemBatch = new HashSet<DIO_PTSLineItemBatch>();
            DIO_PurchaseInvoiceBatch = new HashSet<DIO_PurchaseInvoiceBatch>();
            DIO_ReturnReceiptBatch = new HashSet<DIO_ReturnReceiptBatch>();
            DIO_ReturnShipmentBatch = new HashSet<DIO_ReturnShipmentBatch>();
            DIO_SaleInvoiceBatch = new HashSet<DIO_SaleInvoiceBatch>();
            DIO_StockInBatch = new HashSet<DIO_StockInBatch>();
            DIO_StockOutBatch = new HashSet<DIO_StockOutBatch>();
            DIO_TransferBatch = new HashSet<DIO_TransferBatch>();
        }

        [Key]
        public int BatchID { get; set; }

        [Required]
        [StringLength(30)]
        public string BatchCode { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int MasterLocationID { get; set; }

        public int MasterItemID { get; set; }

        public decimal? Quantity { get; set; }

        [StringLength(30)]
        public string ManufactureNumber { get; set; }

        public DateTime? ManufacturingDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public bool? Activated { get; set; }

        public decimal? QtyInUsed { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? IndividualQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? CartonQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TmpQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? TmpIndividualQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TmpCartonQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? NPSelectedQuantity { get; set; }

        public int? Vendor { get; set; }

        [StringLength(200)]
        public string Pedigree_Number { get; set; }

        [StringLength(20)]
        public string GTIN { get; set; }

        public byte[] ManufacturingRecord { get; set; }

        public byte[] PackingRecord { get; set; }

        public byte[] InventoryRecord { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(250)]
        public string ManufacturingRecordInfo { get; set; }

        [StringLength(250)]
        public string PackingRecordInfo { get; set; }

        [StringLength(250)]
        public string InventoryRecordInfo { get; set; }

        public bool? IsAllocated { get; set; }

        [StringLength(100)]
        public string ContainerNo { get; set; }

        public DateTime? ReceivedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentBatch> DIO_AdjustmentBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Batch_ReceivedDate> DIO_Batch_ReceivedDate { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BatchContainer> DIO_BatchContainer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryAdviceDetail> DIO_InventoryAdviceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdviceBatch> DIO_InventoryLineItemShippingAdviceBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_IVABatch> DIO_IVABatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LineItemDetailBatch> DIO_LineItemDetailBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LocationManagementDetailBatch> DIO_LocationManagementDetailBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_nInventoryLineItemBatch> DIO_nInventoryLineItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetailItemBatch> DIO_PackDetailItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailItemBatch> DIO_PickDetailItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickingListDetailBatch> DIO_PickingListDetailBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingBatch> DIO_ReceivingBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingCartonItemBatch> DIO_ReceivingCartonItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderDetailBatch> DIO_WHOrderDetailBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceDetailBatch> DIO_WHShippingAdviceDetailBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrderInBatch> DIO_WorkOrderInBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceLineItemBatch> DIO_WSTReceiptAdviceLineItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceLineItemBatch> DIO_WSTShipmentAdviceLineItemBatch { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LineItemBatch> DIO_LineItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPackBatch> DIO_OpenPackBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPackDetailBatch> DIO_OpenPackDetailBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemBatch> DIO_PackItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemDetailLocationBatch> DIO_PackItemDetailLocationBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSLineItemBatch> DIO_PTSLineItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PurchaseInvoiceBatch> DIO_PurchaseInvoiceBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnReceiptBatch> DIO_ReturnReceiptBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnShipmentBatch> DIO_ReturnShipmentBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SaleInvoiceBatch> DIO_SaleInvoiceBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockInBatch> DIO_StockInBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockOutBatch> DIO_StockOutBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferBatch> DIO_TransferBatch { get; set; }
    }
}
