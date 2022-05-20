namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WSTShipmentAdviceLineItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WSTShipmentAdviceLineItem()
        {
            DIO_WSTShipmentAdviceLineItemBatch = new HashSet<DIO_WSTShipmentAdviceLineItemBatch>();
            DIO_WSTShipmentAdviceLineItemDetail = new HashSet<DIO_WSTShipmentAdviceLineItemDetail>();
            DIO_WSTShipmentAdviceLineItemSerial = new HashSet<DIO_WSTShipmentAdviceLineItemSerial>();
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
        public string ShipmentStatusCode { get; set; }

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
        public decimal? ReceivingQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TmpReceivedQty { get; set; }

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

        public int? MasterItemID { get; set; }

        public int? OrderUOM { get; set; }

        public int? CommitUOM { get; set; }

        public int? CommitBaseUOM { get; set; }

        public int? PackUOM { get; set; }

        public int? WeightUOM { get; set; }

        public int? VolumnUOM { get; set; }

        public int? ShippedUOM { get; set; }

        public int? ShipmentAdvicePOId { get; set; }

        public int? ShipmentAdvicePalletPOId { get; set; }

        public int? ShipmentAdviceCartonId { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? To944 { get; set; }

        [StringLength(100)]
        public string CasePackInfo { get; set; }

        public int? InnerPackQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCarton { get; set; }

        public virtual DIO_WSTShipmentAdviceCarton DIO_WSTShipmentAdviceCarton { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure3 { get; set; }

        public virtual DIO_WSTShipmentAdvicePalletPO DIO_WSTShipmentAdvicePalletPO { get; set; }

        public virtual DIO_WSTShipmentAdvicePO DIO_WSTShipmentAdvicePO { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure4 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure5 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure6 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceLineItemBatch> DIO_WSTShipmentAdviceLineItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceLineItemDetail> DIO_WSTShipmentAdviceLineItemDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceLineItemSerial> DIO_WSTShipmentAdviceLineItemSerial { get; set; }
    }
}
