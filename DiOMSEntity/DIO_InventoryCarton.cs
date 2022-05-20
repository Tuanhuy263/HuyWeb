namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryCarton
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_InventoryCarton()
        {
            DIO_AdjustmentCarton = new HashSet<DIO_AdjustmentCarton>();
            DIO_InventoryCartonShippingAdvice = new HashSet<DIO_InventoryCartonShippingAdvice>();
            DIO_PackDetailCarton = new HashSet<DIO_PackDetailCarton>();
            DIO_WHShippingAdviceDetailCarton = new HashSet<DIO_WHShippingAdviceDetailCarton>();
            DIO_WSTReceiptAdviceCarton = new HashSet<DIO_WSTReceiptAdviceCarton>();
            DIO_InventoryLineItem = new HashSet<DIO_InventoryLineItem>();
            DIO_InventoryRepackCarton = new HashSet<DIO_InventoryRepackCarton>();
            DIO_InventoryRepackCarton1 = new HashSet<DIO_InventoryRepackCarton>();
            DIO_PickDetailCarton = new HashSet<DIO_PickDetailCarton>();
            TmpAdjustmentCartons = new HashSet<TmpAdjustmentCarton>();
            TmpTransferCartons = new HashSet<TmpTransferCarton>();
            DIO_TransferCarton = new HashSet<DIO_TransferCarton>();
        }

        [Key]
        public int CartonNo { get; set; }

        public int? PalletNo { get; set; }

        public int? MasterLocationID { get; set; }

        public int? WHStockInNo { get; set; }

        [Required]
        [StringLength(50)]
        public string CartonCode { get; set; }

        [Required]
        [StringLength(50)]
        public string CartonQualifier { get; set; }

        [StringLength(50)]
        public string TransactionNumber { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Volume { get; set; }

        public int? Status { get; set; }

        public bool? IsInUsed { get; set; }

        public bool? IsActivated { get; set; }

        public int? ObjectType { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ReplicationDate { get; set; }

        public bool? IsScanned { get; set; }

        public bool? IsPicked { get; set; }

        public int? OriginalMasterLocationID { get; set; }

        public bool? IsPacked { get; set; }

        public int? WeightUOM { get; set; }

        public int? VolumeUOM { get; set; }

        public bool? IsNew { get; set; }

        [StringLength(100)]
        public string OldLocation { get; set; }

        public int? InventoryStatus { get; set; }

        public int? InventoryReason { get; set; }

        public int? OldPalletNo { get; set; }

        public DateTime? ReceivedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentCarton> DIO_AdjustmentCarton { get; set; }

        public virtual DIO_InventoryReason DIO_InventoryReason { get; set; }

        public virtual DIO_InventoryStatus DIO_InventoryStatus { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryCartonShippingAdvice> DIO_InventoryCartonShippingAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetailCarton> DIO_PackDetailCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceDetailCarton> DIO_WHShippingAdviceDetailCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceCarton> DIO_WSTReceiptAdviceCarton { get; set; }

        public virtual DIO_InventoryPallet DIO_InventoryPallet { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }

        public virtual DIO_WHStockIn DIO_WHStockIn { get; set; }

        public virtual XPObjectType XPObjectType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItem> DIO_InventoryLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryRepackCarton> DIO_InventoryRepackCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryRepackCarton> DIO_InventoryRepackCarton1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailCarton> DIO_PickDetailCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpAdjustmentCarton> TmpAdjustmentCartons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpTransferCarton> TmpTransferCartons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferCarton> DIO_TransferCarton { get; set; }
    }
}
