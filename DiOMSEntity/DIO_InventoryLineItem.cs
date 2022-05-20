namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryLineItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_InventoryLineItem()
        {
            DIO_InventoryLineItemShippingAdvice = new HashSet<DIO_InventoryLineItemShippingAdvice>();
            DIO_LineItemSerial = new HashSet<DIO_LineItemSerial>();
            DIO_LineItemBatch = new HashSet<DIO_LineItemBatch>();
        }

        [Key]
        public int LineItemID { get; set; }

        public int MasterItemID { get; set; }

        public int? CartonNo { get; set; }

        public decimal? Quantity { get; set; }

        public int? UnitOfMeasure { get; set; }

        public int? UnitOfMeasureBase { get; set; }

        public decimal? UOMRate { get; set; }

        public decimal? Weight { get; set; }

        public int? WeightUOM { get; set; }

        public decimal? Volume { get; set; }

        public int? VolumeUOM { get; set; }

        public byte? Status { get; set; }

        public int? ObjectType { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? ReplicationDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? NPUsedQuantityInTransaction { get; set; }

        [Column(TypeName = "money")]
        public decimal? CountQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedQty { get; set; }

        public bool? NPIsUsedInTransaction { get; set; }

        [Column(TypeName = "money")]
        public decimal? Difference { get; set; }

        public bool? IsNew { get; set; }

        public int? Pallet { get; set; }

        public int? InventoryStatus { get; set; }

        public virtual DIO_InventoryCarton DIO_InventoryCarton { get; set; }

        public virtual DIO_InventoryStatus DIO_InventoryStatus { get; set; }

        public virtual DIO_InventoryPallet DIO_InventoryPallet { get; set; }

        public virtual XPObjectType XPObjectType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdvice> DIO_InventoryLineItemShippingAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LineItemSerial> DIO_LineItemSerial { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LineItemBatch> DIO_LineItemBatch { get; set; }
    }
}
