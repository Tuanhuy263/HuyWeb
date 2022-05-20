namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHStockIn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHStockIn()
        {
            DIO_InventoryCarton = new HashSet<DIO_InventoryCarton>();
            DIO_InventoryPallet = new HashSet<DIO_InventoryPallet>();
            DIO_LandedCostHeader = new HashSet<DIO_LandedCostHeader>();
            DIO_ReturnReceipt = new HashSet<DIO_ReturnReceipt>();
            DIO_StockInExpenditure = new HashSet<DIO_StockInExpenditure>();
            DIO_StockInFreight = new HashSet<DIO_StockInFreight>();
            DIS_PurchaseInvoiceHeader = new HashSet<DIS_PurchaseInvoiceHeader>();
            DIO_WHStockInDetail = new HashSet<DIO_WHStockInDetail>();
        }

        [Key]
        public int WHStockInNo { get; set; }

        public int? FromMasterLocationID { get; set; }

        public int? ToMasterLocationID { get; set; }

        public int? VendorID { get; set; }

        public DateTime? DateOfReceive { get; set; }

        [StringLength(250)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        [StringLength(20)]
        public string BillNo { get; set; }

        public int? WHRecipientNoticeNo { get; set; }

        [StringLength(30)]
        public string ManufactureOrderNo { get; set; }

        public byte? Status { get; set; }

        public int? PONo { get; set; }

        public decimal? DiscountPercent { get; set; }

        public decimal? DiscountAmount { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? ASNNo { get; set; }

        public int? TransferDocumentHeaderID { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        public DateTime? QBModifiedTime { get; set; }

        public bool? IsDropShip { get; set; }

        public bool? IsGeneratePI { get; set; }

        [StringLength(250)]
        public string ExternalPONumber { get; set; }

        [StringLength(50)]
        public string VendorNo { get; set; }

        [StringLength(50)]
        public string VendorName { get; set; }

        [StringLength(250)]
        public string SupplierName { get; set; }

        [StringLength(250)]
        public string SupplierCode { get; set; }

        [StringLength(250)]
        public string ShipmentReference { get; set; }

        [StringLength(250)]
        public string BOL { get; set; }

        [StringLength(250)]
        public string Carrier { get; set; }

        public bool? IsGenerated944 { get; set; }

        [StringLength(250)]
        public string SmartTurnDocumentNo { get; set; }

        [StringLength(250)]
        public string WarehouseID { get; set; }

        [StringLength(100)]
        public string ContainerNo { get; set; }

        [StringLength(100)]
        public string SealNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalQty { get; set; }

        public byte? Container_Type { get; set; }

        public DateTime? BBD { get; set; }

        public int? EPCIS_ID { get; set; }

        public bool? IsCreatedFromSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryCarton> DIO_InventoryCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryPallet> DIO_InventoryPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LandedCostHeader> DIO_LandedCostHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnReceipt> DIO_ReturnReceipt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockInExpenditure> DIO_StockInExpenditure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockInFreight> DIO_StockInFreight { get; set; }

        public virtual DIO_TransferDocumentHeader DIO_TransferDocumentHeader { get; set; }

        public virtual DIO_WHRecipientNoticeHeader DIO_WHRecipientNoticeHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceHeader> DIS_PurchaseInvoiceHeader { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_POHeader DIS_POHeader { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockInDetail> DIO_WHStockInDetail { get; set; }
    }
}
