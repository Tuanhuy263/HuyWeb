namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WSTReceiptAdviceLineItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WSTReceiptAdviceLineItem()
        {
            DIO_WSTReceiptAdviceLineItemBatch = new HashSet<DIO_WSTReceiptAdviceLineItemBatch>();
            DIO_WSTReceiptAdviceLineItemDetail = new HashSet<DIO_WSTReceiptAdviceLineItemDetail>();
            DIO_WSTReceiptAdviceLineItemSerial = new HashSet<DIO_WSTReceiptAdviceLineItemSerial>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int LineItemNo { get; set; }

        public int? LineNumber { get; set; }

        [StringLength(100)]
        public string EDILnNo { get; set; }

        public int? Status { get; set; }

        [StringLength(2)]
        public string ReceiptStatusCode { get; set; }

        [StringLength(100)]
        public string ItemDescription { get; set; }

        [StringLength(100)]
        public string SizeDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? Volume { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalVolume { get; set; }

        [Column(TypeName = "money")]
        public decimal? Length { get; set; }

        [Column(TypeName = "money")]
        public decimal? Width { get; set; }

        [Column(TypeName = "money")]
        public decimal? Height { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? CommitQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? PackedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReceivedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? OriginalQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyShippedToDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? UPSWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? UPSHeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? UPSLength { get; set; }

        [Column(TypeName = "money")]
        public decimal? UPSWidth { get; set; }

        [Column(TypeName = "money")]
        public decimal? CommitUOMRate { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        [StringLength(100)]
        public string LocationWithQty { get; set; }

        [StringLength(100)]
        public string OldLocation { get; set; }

        [StringLength(100)]
        public string OldLocationDescription { get; set; }

        public int? ItemLocation { get; set; }

        public int? MasterItemID { get; set; }

        public int? OrderUOM { get; set; }

        public int? CommitUOM { get; set; }

        public int? CommitBaseUOM { get; set; }

        public int? PackUOM { get; set; }

        public int? WeightUOM { get; set; }

        public int? VolumnUOM { get; set; }

        public int? ShippedUOM { get; set; }

        public int? InventoryStatus { get; set; }

        public int? ReceiptAdvicePOId { get; set; }

        public int? ReceiptAdvicePalletPOId { get; set; }

        public int? ReceiptAdviceCartonId { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pack { get; set; }

        [Column(TypeName = "money")]
        public decimal? InnerPack { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCartons { get; set; }

        public DateTime? ProductReceiptDate { get; set; }

        public int? UOM { get; set; }

        [StringLength(100)]
        public string ReceivingConditionCode { get; set; }

        [StringLength(100)]
        public string DamageReasonCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalQuantityReceived { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalUnitsShipped { get; set; }

        [StringLength(255)]
        public string ProductCode1 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(255)]
        public string ProductCode2 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(100)]
        public string ProductCode3 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(100)]
        public string ProductCode4 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(100)]
        public string ProductCode5 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(100)]
        public string ProductCode6 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(100)]
        public string ProductCode7 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(100)]
        public string ProductCode8 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(100)]
        public string ProductCode9 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier10 { get; set; }

        [StringLength(100)]
        public string ProductCode10 { get; set; }

        public virtual DIO_InventoryStatus DIO_InventoryStatus { get; set; }

        public virtual DIO_WSTReceiptAdviceCarton DIO_WSTReceiptAdviceCarton { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure3 { get; set; }

        public virtual DIO_WSTReceiptAdvicePalletPO DIO_WSTReceiptAdvicePalletPO { get; set; }

        public virtual DIO_WSTReceiptAdvicePO DIO_WSTReceiptAdvicePO { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure4 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure5 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure6 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure7 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceLineItemBatch> DIO_WSTReceiptAdviceLineItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceLineItemDetail> DIO_WSTReceiptAdviceLineItemDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceLineItemSerial> DIO_WSTReceiptAdviceLineItemSerial { get; set; }
    }
}
