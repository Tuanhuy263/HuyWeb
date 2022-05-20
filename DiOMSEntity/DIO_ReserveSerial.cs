namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReserveSerial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReserveSerial()
        {
            DIO_nSerial = new HashSet<DIO_nSerial>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int SerialID { get; set; }

        [StringLength(30)]
        public string LotNumber { get; set; }

        [StringLength(30)]
        public string SerialNumber { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public int? MasterItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? UnitOfMeasureID { get; set; }

        public bool? IsUsed { get; set; }

        [StringLength(20)]
        public string GTIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_nSerial> DIO_nSerial { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }
    }
}
