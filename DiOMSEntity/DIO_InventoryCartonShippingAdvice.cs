namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryCartonShippingAdvice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_InventoryCartonShippingAdvice()
        {
            DIO_InventoryLineItemShippingAdvice = new HashSet<DIO_InventoryLineItemShippingAdvice>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int CartonNo { get; set; }

        [StringLength(50)]
        public string CartonCode { get; set; }

        [StringLength(50)]
        public string CartonQualifier { get; set; }

        [StringLength(50)]
        public string TransactionNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal? Volume { get; set; }

        public int? Status { get; set; }

        public bool? IsNew { get; set; }

        public bool? IsActivated { get; set; }

        public bool? IsPicked { get; set; }

        public bool? IsPacked { get; set; }

        public bool? IsInUsed { get; set; }

        public int? MasterLocationID { get; set; }

        public int? OriginalMasterLocationID { get; set; }

        public int? InventoryPalletShippingAdviceNo { get; set; }

        public int? WeightUOM { get; set; }

        public int? VolumeUOM { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? InventoryCartonID { get; set; }

        public int? WHShippingAdviceDetailID { get; set; }

        public virtual DIO_InventoryCarton DIO_InventoryCarton { get; set; }

        public virtual DIO_InventoryPalletShippingAdvice DIO_InventoryPalletShippingAdvice { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIO_WHShippingAdviceDetail DIO_WHShippingAdviceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdvice> DIO_InventoryLineItemShippingAdvice { get; set; }
    }
}
