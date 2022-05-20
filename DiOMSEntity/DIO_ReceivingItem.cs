namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReceivingItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReceivingItem()
        {
            DIO_ReceivingBatch = new HashSet<DIO_ReceivingBatch>();
            DIO_ReceivingSerial = new HashSet<DIO_ReceivingSerial>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReceivingItemNo { get; set; }

        public bool? IsScanned { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? ReceivingUserNo { get; set; }

        public int? MasterItemID { get; set; }

        public int? UnitOfMeasureID { get; set; }

        public int? MasterLocationID { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingBatch> DIO_ReceivingBatch { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_ReceivingUser DIO_ReceivingUser { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingSerial> DIO_ReceivingSerial { get; set; }
    }
}
