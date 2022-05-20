namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHShippingAdviceDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHShippingAdviceDetail()
        {
            DIO_InventoryCartonShippingAdvice = new HashSet<DIO_InventoryCartonShippingAdvice>();
            DIO_InventoryLineItemShippingAdvice = new HashSet<DIO_InventoryLineItemShippingAdvice>();
            DIO_InventoryLineItemShippingAdviceBatch = new HashSet<DIO_InventoryLineItemShippingAdviceBatch>();
            DIO_InventoryLineItemShippingAdviceSerial = new HashSet<DIO_InventoryLineItemShippingAdviceSerial>();
            DIO_InventoryPalletShippingAdvice = new HashSet<DIO_InventoryPalletShippingAdvice>();
            DIO_ItemShippingAdvice = new HashSet<DIO_ItemShippingAdvice>();
            DIO_WHShippingAdviceDetailBatch = new HashSet<DIO_WHShippingAdviceDetailBatch>();
            DIO_WHShippingAdviceDetailCarton = new HashSet<DIO_WHShippingAdviceDetailCarton>();
            DIO_WHShippingAdviceDetailPallet = new HashSet<DIO_WHShippingAdviceDetailPallet>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WHShippingAdviceDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShipmentQuantity { get; set; }

        public int? UnitOfMeasureID { get; set; }

        public int? MasterItemID { get; set; }

        public int? WHShippingAdviceHeaderID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? WHShippingOrderDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? NPSelectedQuantity { get; set; }

        public int? LnNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? PalletLadingQty { get; set; }

        [StringLength(100)]
        public string ProductCode1 { get; set; }

        [StringLength(100)]
        public string ProductCode2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShipWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderQty { get; set; }

        [StringLength(100)]
        public string ProductCode3 { get; set; }

        [StringLength(100)]
        public string ProductCode4 { get; set; }

        [StringLength(100)]
        public string ProductCode5 { get; set; }

        [StringLength(100)]
        public string ProductCode6 { get; set; }

        [StringLength(100)]
        public string ProductCode7 { get; set; }

        [StringLength(100)]
        public string ProductCode8 { get; set; }

        [StringLength(100)]
        public string ProductCode9 { get; set; }

        [StringLength(100)]
        public string ProductCode10 { get; set; }

        [StringLength(100)]
        public string EDILnNo { get; set; }

        [StringLength(100)]
        public string EDIItemDescription { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier10 { get; set; }

        public int? SODetail { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        [StringLength(100)]
        public string CartonCodeForPacking { get; set; }

        [StringLength(255)]
        public string ProductDescription { get; set; }

        [StringLength(10)]
        public string WeightUOM { get; set; }

        [StringLength(255)]
        public string UPCCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDiff { get; set; }

        public DateTime? LotNoDate { get; set; }

        [StringLength(255)]
        public string VehicleIDNo { get; set; }

        [StringLength(255)]
        public string ManifestNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyOrdered { get; set; }

        [StringLength(10)]
        public string StatusType { get; set; }

        [StringLength(10)]
        public string WeightQualifier { get; set; }

        [StringLength(255)]
        public string LotNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedQtyLot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryCartonShippingAdvice> DIO_InventoryCartonShippingAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdvice> DIO_InventoryLineItemShippingAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdviceBatch> DIO_InventoryLineItemShippingAdviceBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdviceSerial> DIO_InventoryLineItemShippingAdviceSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryPalletShippingAdvice> DIO_InventoryPalletShippingAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ItemShippingAdvice> DIO_ItemShippingAdvice { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_SODetail DIS_SODetail { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIO_WHShippingAdviceHeader DIO_WHShippingAdviceHeader { get; set; }

        public virtual DIO_WHShippingOrderDetail DIO_WHShippingOrderDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceDetailBatch> DIO_WHShippingAdviceDetailBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceDetailCarton> DIO_WHShippingAdviceDetailCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceDetailPallet> DIO_WHShippingAdviceDetailPallet { get; set; }
    }
}
