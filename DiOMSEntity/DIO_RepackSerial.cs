namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RepackSerial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RepackSerial()
        {
            DIO_RepackSerialItem = new HashSet<DIO_RepackSerialItem>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RepackSerialID { get; set; }

        [StringLength(30)]
        public string DocumentNO { get; set; }

        public DateTime? RepackDate { get; set; }

        public int? MasterLocationID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RepackSerialItem> DIO_RepackSerialItem { get; set; }
    }
}
