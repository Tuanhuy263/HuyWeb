namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Serial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Serial()
        {
            DIO_AdjustmentSerial = new HashSet<DIO_AdjustmentSerial>();
            DIO_InventoryLineItemShippingAdviceSerial = new HashSet<DIO_InventoryLineItemShippingAdviceSerial>();
            DIO_LineItemSerial = new HashSet<DIO_LineItemSerial>();
            DIO_OpenPackDetailSerial = new HashSet<DIO_OpenPackDetailSerial>();
            DIO_OpenPackSerial = new HashSet<DIO_OpenPackSerial>();
            DIO_PackDetailItemSerial = new HashSet<DIO_PackDetailItemSerial>();
            DIO_PackItemDetailLocationSerial = new HashSet<DIO_PackItemDetailLocationSerial>();
            DIO_PackItemSerial = new HashSet<DIO_PackItemSerial>();
            DIO_PickDetailItemSerial = new HashSet<DIO_PickDetailItemSerial>();
            DIO_PickingListDetailSerial = new HashSet<DIO_PickingListDetailSerial>();
            DIO_PTSLineItemSerial = new HashSet<DIO_PTSLineItemSerial>();
            DIO_PurchaseInvoiceSerial = new HashSet<DIO_PurchaseInvoiceSerial>();
            DIO_ReceivingCartonItemSerial = new HashSet<DIO_ReceivingCartonItemSerial>();
            DIO_ReceivingSerial = new HashSet<DIO_ReceivingSerial>();
            DIO_ReturnReceiptSerial = new HashSet<DIO_ReturnReceiptSerial>();
            DIO_ReturnShipmentSerial = new HashSet<DIO_ReturnShipmentSerial>();
            DIO_SaleInvoiceSerial = new HashSet<DIO_SaleInvoiceSerial>();
            DIO_Serial1 = new HashSet<DIO_Serial>();
            DIO_WHOrderDetailSerial = new HashSet<DIO_WHOrderDetailSerial>();
            DIO_WorkOrderInSerial = new HashSet<DIO_WorkOrderInSerial>();
            DIO_WSTReceiptAdviceLineItemSerial = new HashSet<DIO_WSTReceiptAdviceLineItemSerial>();
            DIO_WSTShipmentAdviceLineItemSerial = new HashSet<DIO_WSTShipmentAdviceLineItemSerial>();
            DIO_StockInSerial = new HashSet<DIO_StockInSerial>();
            DIO_StockOutSerial = new HashSet<DIO_StockOutSerial>();
            DIO_TransferSerial = new HashSet<DIO_TransferSerial>();
        }

        [Key]
        public int SerialID { get; set; }

        [StringLength(30)]
        public string LotNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string SerialNumber { get; set; }

        [StringLength(30)]
        public string ManufactureNumber { get; set; }

        public DateTime? ManufacturingDate { get; set; }

        public int? MasterItemID { get; set; }

        public int? MasterLocationID { get; set; }

        public bool Activated { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public bool? IsUsed { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? LineItemID { get; set; }

        public bool? IsAllocated { get; set; }

        public bool? IsScanned { get; set; }

        public bool? IsPicked { get; set; }

        public int? LocationManagementDetailID { get; set; }

        public int? InventoryStatus { get; set; }

        public bool? IsIndividual { get; set; }

        public int? UOM { get; set; }

        public int? Parent { get; set; }

        [StringLength(20)]
        public string GTIN { get; set; }

        [StringLength(30)]
        public string Parent_SerialNumber { get; set; }

        public int? Parent_UOMID { get; set; }

        public int? Parent_ItemID { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string Pedigree { get; set; }

        public bool? IsFromBarcode { get; set; }

        public DateTime? ReceivedDate { get; set; }

        [StringLength(100)]
        public string EPCIS_SerialNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentSerial> DIO_AdjustmentSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdviceSerial> DIO_InventoryLineItemShippingAdviceSerial { get; set; }

        public virtual DIO_InventoryStatus DIO_InventoryStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LineItemSerial> DIO_LineItemSerial { get; set; }

        public virtual DIO_LocationManagementDetail DIO_LocationManagementDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPackDetailSerial> DIO_OpenPackDetailSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPackSerial> DIO_OpenPackSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetailItemSerial> DIO_PackDetailItemSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemDetailLocationSerial> DIO_PackItemDetailLocationSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemSerial> DIO_PackItemSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailItemSerial> DIO_PickDetailItemSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickingListDetailSerial> DIO_PickingListDetailSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSLineItemSerial> DIO_PTSLineItemSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PurchaseInvoiceSerial> DIO_PurchaseInvoiceSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingCartonItemSerial> DIO_ReceivingCartonItemSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingSerial> DIO_ReceivingSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnReceiptSerial> DIO_ReturnReceiptSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnShipmentSerial> DIO_ReturnShipmentSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SaleInvoiceSerial> DIO_SaleInvoiceSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Serial> DIO_Serial1 { get; set; }

        public virtual DIO_Serial DIO_Serial2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderDetailSerial> DIO_WHOrderDetailSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrderInSerial> DIO_WorkOrderInSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceLineItemSerial> DIO_WSTReceiptAdviceLineItemSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceLineItemSerial> DIO_WSTShipmentAdviceLineItemSerial { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockInSerial> DIO_StockInSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockOutSerial> DIO_StockOutSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferSerial> DIO_TransferSerial { get; set; }
    }
}
