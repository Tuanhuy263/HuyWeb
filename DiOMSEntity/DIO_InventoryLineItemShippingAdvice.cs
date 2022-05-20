namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryLineItemShippingAdvice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_InventoryLineItemShippingAdvice()
        {
            DIO_InventoryLineItemShippingAdviceBatch = new HashSet<DIO_InventoryLineItemShippingAdviceBatch>();
            DIO_InventoryLineItemShippingAdviceSerial = new HashSet<DIO_InventoryLineItemShippingAdviceSerial>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int LineItemID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? CountQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal? Volume { get; set; }

        public byte? Status { get; set; }

        public bool? NPIsUsedInTransaction { get; set; }

        public int? InventoryCartonShippingAdviceNo { get; set; }

        public int? WHShippingAdviceDetailID { get; set; }

        public int? MasterItemID { get; set; }

        public int? UnitOfMeasure { get; set; }

        public int? UnitOfMeasureBase { get; set; }

        public int? WeightUOM { get; set; }

        public int? VolumeUOM { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? InventoryLineItemID { get; set; }

        public int? MasterLocationID { get; set; }

        public int? InventoryPalletShippingAdviceNo { get; set; }

        public virtual DIO_InventoryCartonShippingAdvice DIO_InventoryCartonShippingAdvice { get; set; }

        public virtual DIO_InventoryLineItem DIO_InventoryLineItem { get; set; }

        public virtual DIO_InventoryPalletShippingAdvice DIO_InventoryPalletShippingAdvice { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure3 { get; set; }

        public virtual DIO_WHShippingAdviceDetail DIO_WHShippingAdviceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdviceBatch> DIO_InventoryLineItemShippingAdviceBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdviceSerial> DIO_InventoryLineItemShippingAdviceSerial { get; set; }
    }
}
