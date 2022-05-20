namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_OpenPackDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_OpenPackDetail()
        {
            DIO_OpenPackDetailBatch = new HashSet<DIO_OpenPackDetailBatch>();
            DIO_OpenPackDetailSerial = new HashSet<DIO_OpenPackDetailSerial>();
        }

        [Key]
        public int OpenPackDetailID { get; set; }

        public int OpenPackID { get; set; }

        public int KitDetailID { get; set; }

        public int MasterLocationID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? TotalQuantityOpened { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public decimal? UnitCost { get; set; }

        public virtual DIO_KitDetail DIO_KitDetail { get; set; }

        public virtual DIO_OpenPack DIO_OpenPack { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPackDetailBatch> DIO_OpenPackDetailBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPackDetailSerial> DIO_OpenPackDetailSerial { get; set; }
    }
}
