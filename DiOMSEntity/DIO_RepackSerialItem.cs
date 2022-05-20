namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RepackSerialItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RepackSerialItem()
        {
            DIO_RepackSerialDetail = new HashSet<DIO_RepackSerialDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RepackSerialItemID { get; set; }

        public int? Quantity { get; set; }

        public int? MasterItemID { get; set; }

        public int? RepackSerialID { get; set; }

        public int? UnitOfMeasureID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_RepackSerial DIO_RepackSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RepackSerialDetail> DIO_RepackSerialDetail { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }
    }
}
