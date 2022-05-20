namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PackItemDetailLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PackItemDetailLocation()
        {
            DIO_PackItemDetailLocationBatch = new HashSet<DIO_PackItemDetailLocationBatch>();
            DIO_PackItemDetailLocationSerial = new HashSet<DIO_PackItemDetailLocationSerial>();
        }

        [Key]
        public int PackItemLocationID { get; set; }

        public int MasterLocationID { get; set; }

        public int PackDetailItemID { get; set; }

        public decimal? Onhand { get; set; }

        public decimal? Allocated { get; set; }

        public decimal? AvailableToPack { get; set; }

        public decimal? Quantity { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? LocationManagement { get; set; }

        public virtual DIO_LocationManagement DIO_LocationManagement { get; set; }

        public virtual DIO_PackItemDetail DIO_PackItemDetail { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemDetailLocationBatch> DIO_PackItemDetailLocationBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemDetailLocationSerial> DIO_PackItemDetailLocationSerial { get; set; }
    }
}
