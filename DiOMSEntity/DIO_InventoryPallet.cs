namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryPallet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_InventoryPallet()
        {
            DIO_AdjustmentPallet = new HashSet<DIO_AdjustmentPallet>();
            DIO_InventoryCarton = new HashSet<DIO_InventoryCarton>();
            DIO_InventoryLineItem = new HashSet<DIO_InventoryLineItem>();
            DIO_InventoryPalletShippingAdvice = new HashSet<DIO_InventoryPalletShippingAdvice>();
            DIO_InventoryPalletShippingAdvice1 = new HashSet<DIO_InventoryPalletShippingAdvice>();
            DIO_PackDetailPallet = new HashSet<DIO_PackDetailPallet>();
            DIO_WHShippingAdviceDetailPallet = new HashSet<DIO_WHShippingAdviceDetailPallet>();
            DIO_WSTReceiptAdvicePallet = new HashSet<DIO_WSTReceiptAdvicePallet>();
            DIO_InventoryPallet1 = new HashSet<DIO_InventoryPallet>();
            DIO_PickDetailPallet = new HashSet<DIO_PickDetailPallet>();
            TmpAdjustmentPallets = new HashSet<TmpAdjustmentPallet>();
            TmpTransferPallets = new HashSet<TmpTransferPallet>();
            DIO_TransferPallet = new HashSet<DIO_TransferPallet>();
        }

        [Key]
        public int PalletNo { get; set; }

        public int MasterLocationID { get; set; }

        [StringLength(50)]
        public string PalletCode { get; set; }

        public decimal? Weight { get; set; }

        public int? WHStockInNo { get; set; }

        public bool? IsInUsed { get; set; }

        public int? OriginalPallet { get; set; }

        public bool? IsActivated { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? Status { get; set; }

        public bool? UnmanagedCarton { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ReplicationDate { get; set; }

        public bool? IsPicked { get; set; }

        public int? OriginalMasterLocationID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Volume { get; set; }

        public int? WeightUOM { get; set; }

        public int? VolumeUOM { get; set; }

        public bool? IsNew { get; set; }

        public int? InventoryStatus { get; set; }

        public int? InventoryReason { get; set; }

        public bool? IsPacked { get; set; }

        public DateTime? ReceivedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentPallet> DIO_AdjustmentPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryCarton> DIO_InventoryCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItem> DIO_InventoryLineItem { get; set; }

        public virtual DIO_InventoryReason DIO_InventoryReason { get; set; }

        public virtual DIO_InventoryStatus DIO_InventoryStatus { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryPalletShippingAdvice> DIO_InventoryPalletShippingAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryPalletShippingAdvice> DIO_InventoryPalletShippingAdvice1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetailPallet> DIO_PackDetailPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceDetailPallet> DIO_WHShippingAdviceDetailPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePallet> DIO_WSTReceiptAdvicePallet { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryPallet> DIO_InventoryPallet1 { get; set; }

        public virtual DIO_InventoryPallet DIO_InventoryPallet2 { get; set; }

        public virtual DIO_WHStockIn DIO_WHStockIn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailPallet> DIO_PickDetailPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpAdjustmentPallet> TmpAdjustmentPallets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpTransferPallet> TmpTransferPallets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferPallet> DIO_TransferPallet { get; set; }
    }
}
