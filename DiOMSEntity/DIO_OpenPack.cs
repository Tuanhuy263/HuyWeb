namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_OpenPack
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_OpenPack()
        {
            DIO_OpenPackBatch = new HashSet<DIO_OpenPackBatch>();
            DIO_OpenPackDetail = new HashSet<DIO_OpenPackDetail>();
            DIO_OpenPackSerial = new HashSet<DIO_OpenPackSerial>();
        }

        [Key]
        public int OpenPackID { get; set; }

        [StringLength(20)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        public int MasterItemID { get; set; }

        public int MasterLocationID { get; set; }

        public decimal? Onhand { get; set; }

        public decimal? Allocated { get; set; }

        public decimal? AvailableToOpen { get; set; }

        public decimal? PackToBeOpened { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        public int? QBAccountID { get; set; }

        public DateTime? QBModifiedDate { get; set; }

        public virtual DIO_MasterKit DIO_MasterKit { get; set; }

        public virtual DIO_QuickBookAccount DIO_QuickBookAccount { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPackBatch> DIO_OpenPackBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPackDetail> DIO_OpenPackDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPackSerial> DIO_OpenPackSerial { get; set; }
    }
}
